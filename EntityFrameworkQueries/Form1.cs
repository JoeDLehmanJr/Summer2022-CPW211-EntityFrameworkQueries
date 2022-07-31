using System.Text;

namespace EntityFrameworkQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelectAllVendars_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new();

            // LINQ (Language Integrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors.ToList();

            // LINQ Query syntax
            List<Vendor> vendorList2 = (from v in dbContext.Vendors select v).ToList();

        }

        private void BtnAllCaliVendors_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new();

            List<Vendor> vendorList = dbContext.Vendors
                                        .Where(v => v.VendorState == "CA")
                                        .OrderBy(v => v.VendorName)
                                        .ToList();

            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                        where v.VendorState == "CA"
                                        orderby v.VendorName
                                        select v).ToList();

        }

        private void BtnSelectSpecificColumns_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new();

            // Anonymous type
            List<VendorLocation> results = (from v in dbContext.Vendors
                          select new VendorLocation
                          {
                              VendorName = v.VendorName,
                              VendorState = v.VendorState,
                              VendorCity = v.VendorCity
                          }).ToList();
            
            StringBuilder displayString = new();
            foreach (VendorLocation vendor in results)
            {
                displayString.AppendLine($"{vendor.VendorName} is in {vendor.VendorCity}." );
            }

            MessageBox.Show(displayString.ToString());
        }

        private void BtnMiscQueries_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new();

            // Check if a vendor exists in Washington
            bool doesExist = (from v in dbContext.Vendors
                             where v.VendorState == "WA"
                             select v).Any();
            
            // Get number of invoices
            int invoiceCoumt = (from invoice in dbContext.Invoices select invoice).Count();

            
            // Query a single vendor
            Vendor singleVendor = (from v in dbContext.Vendors
                          where v.VendorName == "IBM"
                          select v).SingleOrDefault();
            
            if (singleVendor != null)
            {
                MessageBox.Show("IBM is in " + singleVendor.VendorCity);
            }
            else
            {
                MessageBox.Show("IBM is not in the database.");
            }
        }
    }

    class VendorLocation {
        public string VendorName { get; set; }
        public string VendorState { get; set; }
        public string VendorCity { get; set; }
    }
}
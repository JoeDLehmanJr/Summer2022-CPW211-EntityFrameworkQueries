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
    }
}
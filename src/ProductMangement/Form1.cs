using ProductManagement.Core.Services;

namespace ProductMangement
{
    public partial class Form1 : Form
    {
        private ProductService productService = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var p = await productService.GetProductsAsync();
            
        }
    }
}

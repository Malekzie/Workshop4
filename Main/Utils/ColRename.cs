namespace Main.Utils
{
    public static class ColRename
    {
        public static void RenameColumns(DataGridView dgv, string dataType)
        {
            switch (dataType)
            {
                case "PackageDTO":
                    RenamePackageColumns(dgv);
                    break;
                case "ProductDTO":
                    RenameProductColumns(dgv);
                    break;
                case "SupplierDTO":
                    RenameSupplierColumns(dgv);
                    break;
                case "ProductSupplierDTO":
                    RenameProductSupplierColumns(dgv);
                    break;
            }
        }

        private static void RenamePackageColumns(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                switch (column.DataPropertyName)
                {
                    case "PackageId":
                        column.HeaderText = "Package ID";
                        break;
                    case "PkgName":
                        column.HeaderText = "Package Name";
                        break;
                    case "PkgStartDate":
                        column.HeaderText = "Start Date";
                        break;
                    case "PkgEndDate":
                        column.HeaderText = "End Date";
                        break;
                    case "PkgDesc":
                        column.HeaderText = "Description";
                        break;
                    case "PkgBasePrice":
                        column.HeaderText = "Base Price";
                        break;
                    case "PkgAgencyCommission":
                        column.HeaderText = "Agency Commission";
                        break;
                }
            }
        }

        private static void RenameProductColumns(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                switch (column.DataPropertyName)
                {
                    case "ProductId":
                        column.HeaderText = "Product ID";
                        break;
                    case "ProdName":
                        column.HeaderText = "Product Name";
                        break;

                }
            }
        }

        private static void RenameSupplierColumns(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                switch (column.DataPropertyName)
                {
                    case "SupplierId":
                        column.HeaderText = "Supplier ID";
                        break;
                    case "SupName":
                        column.HeaderText = "Supplier Name";
                        break;
                        // Add more case statements for other supplier columns as needed
                }
            }
        }

        private static void RenameProductSupplierColumns(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                switch (column.DataPropertyName)
                {
                    case "ProductSupplierId":
                        column.HeaderText = "Product Supplier ID";
                        break;
                    case "ProductId":
                        column.HeaderText = "Product ID";
                        break;
                    case "SupplierId":
                        column.HeaderText = "Supplier ID";
                        break;
                        // Add more case statements for other product supplier columns as needed
                }
            }
        }
    }
}

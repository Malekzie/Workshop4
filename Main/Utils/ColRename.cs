// Threaded Project 2 Workshop 4 
// Created by Robbie Soriano
// Modified by Ryan Medeiros
// Defines utilities for renaming the columns in a DataGridView. 

namespace Main.Utils
{

    public static class ColRename
    {
        // Defines our column names based on our given database object type.
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

        //If the given type is a Package,
        private static void RenamePackageColumns(DataGridView dgv)
        {
            //For every column within our DataGridView on the primary form,
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                //Set our column headers and styles based on which database column they represent. 
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
                        column.DefaultCellStyle.Format ="dd/MM/yyyy";
                        break;
                    case "PkgEndDate":
                        column.HeaderText = "End Date";
                        column.DefaultCellStyle.Format = "dd/MM/yyyy";
                        break;
                    case "PkgDesc":
                        column.HeaderText = "Description";
                        break;
                    case "PkgBasePrice":
                        column.HeaderText = "Base Price";
                        column.DefaultCellStyle.Format = "c";
                        break;
                    case "PkgAgencyCommission":
                        column.HeaderText = "Agency Commission";
                        column.DefaultCellStyle.Format = "c";
                        break;
                }
            }
        }

        //If the given type is a Package,
        private static void RenameProductColumns(DataGridView dgv)
        {
            //For every column within our DataGridView on the primary form,
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                //Set our column headers and styles based on which database column they represent. 
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

        //If the given type is a Supplier,
        private static void RenameSupplierColumns(DataGridView dgv)
        {
            //For every column within our DataGridView on the primary form,
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                //Set our column headers and styles based on which database column they represent. 
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

        //If the given type is a Supplier,
        private static void RenameProductSupplierColumns(DataGridView dgv)
        {
            //For every column within our DataGridView on the primary form,
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                //Set our column headers and styles based on which database column they represent. 
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

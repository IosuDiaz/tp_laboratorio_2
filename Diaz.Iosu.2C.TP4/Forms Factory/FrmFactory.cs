using Entities.Components;
using Entities;
using Entities.Exceptions;
using Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace Forms_Factory
{

    public delegate void ClearUsedData();
    public partial class FrmFactory : Form
    {
        Computer computer;
        Notebook notebook;
        PC pc;
        public FrmFactory()
        {
            InitializeComponent();
            this.HideButtons();
        }

        private void FrmFactory_Load(object sender, EventArgs e)
        {
            this.rtbListaProductos.Text = Factory.ListPrimaryStock();
        }
        /// <summary>
        /// Start the process of assembling a notebook
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssembleNotebook_Click(object sender, EventArgs e)
        {
            this.computer = Assembler.Assemble<Computer>();
            this.notebook = Assembler.Assemble<Notebook>();

            //Hidding buttons
            this.btnAssemblePC.Visible = false;
            this.btnAssembleMotherboard.Visible = true;
            this.lblSelectComponents.Visible = true;
            //Showing Generic Component Form
            FrmSelectingComponent<Display> selectingComponent = new FrmSelectingComponent<Display>(Factory.SecondaryStock.Filter<Display>());
            selectingComponent.ShowDialog();

            try
            {

                if (selectingComponent.DialogResult == DialogResult.Cancel)
                {
                    this.notebook.Display = selectingComponent.Return;
                    if (!(this.notebook.Display is null))
                    {
                        this.rtbCurrentAssembling.Text += this.notebook.Display.ToString();

                    }
                    else
                    {
                        throw new MissingComponentException("Factory cannot assemble this product without a gabinet");
                    }
                }
            }
            catch (MissingComponentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Start the process of assembling a PC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnsamblarPC_Click(object sender, EventArgs e)
        {

            this.computer = Assembler.Assemble<Computer>();
            this.pc = Assembler.Assemble<PC>();
            this.btnAssembleNotebook.Visible = false;
            this.btnAssembleMotherboard.Visible = true;
            this.lblSelectComponents.Visible = true;
            FrmSelectingComponent<Gabinet> selectingComponent = new FrmSelectingComponent<Gabinet>(Factory.SecondaryStock.Filter<Gabinet>());
            selectingComponent.ShowDialog();
            try
            {

                if (selectingComponent.DialogResult == DialogResult.Cancel)
                {
                    this.pc.Gabinet = selectingComponent.Return;
                    if (!(this.pc.Gabinet is null))
                    {
                        this.rtbCurrentAssembling.Text += this.pc.Gabinet.ToString();

                    }
                    else
                    {
                        throw new MissingComponentException("Factory cannot assemble this product without a gabinet");
                    }
                }
            }
            catch (MissingComponentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Start the selecting process of a Motherboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssembleMotherboard_Click(object sender, EventArgs e)
        {
            FrmSelectingComponent<Motherboard> selectingComponent = new FrmSelectingComponent<Motherboard>(Factory.SecondaryStock.Filter<Motherboard>());

            selectingComponent.ShowDialog();
            this.btnAssembleProcessor.Visible = true;
            try
            {
                if (selectingComponent.DialogResult == DialogResult.Cancel)
                {
                    this.computer.Motherboard = selectingComponent.Return;
                    if (!(this.computer.Motherboard is null))
                    {
                        this.rtbCurrentAssembling.Text += this.computer.Motherboard.ToString();

                    }
                    else
                    {
                        throw new MissingComponentException("Factory cannot assemble this product without a Motherboard");
                    }
                }

            }
            catch (MissingComponentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Start the selecting process of a Processor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssembleProcessor_Click(object sender, EventArgs e)
        {
            FrmSelectingComponent<Processor> selectingComponent = new FrmSelectingComponent<Processor>(Factory.SecondaryStock.Filter<Processor>());

            selectingComponent.ShowDialog();
            this.btnAssembleRam.Visible = true;
            try
            {

                if (selectingComponent.DialogResult == DialogResult.Cancel)
                {
                    this.computer.Motherboard.Processor = selectingComponent.Return;

                    if (!(this.computer.Motherboard.Processor is null))
                    {
                        this.rtbCurrentAssembling.Text += this.computer.Motherboard.Processor.ToString();
                    }
                    else
                    {

                        throw new MissingComponentException("Factory cannot assemble this product without a Processor");
                    }
                }
            }
            catch (MissingComponentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Start the selecting process of a RAM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssembleRam_Click(object sender, EventArgs e)
        {
            FrmSelectingComponent<Ram> selectingComponent = new FrmSelectingComponent<Ram>(Factory.SecondaryStock.Filter<Ram>());

            selectingComponent.ShowDialog();
            this.btnAssembleGraphicCard.Visible = true;
            try
            {

                if (selectingComponent.DialogResult == DialogResult.Cancel)
                {
                    this.computer.Motherboard.Ram = selectingComponent.Return;
                    if (!(this.computer.Motherboard.Ram is null))
                    {
                        this.rtbCurrentAssembling.Text += this.computer.Motherboard.Ram.ToString();

                    }
                    else
                    {
                        throw new MissingComponentException("Factory cannot assemble this product without a RAM");
                    }
                }
            }
            catch (MissingComponentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Start the selecting process of a Power Source
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssemblePowerSupply_Click(object sender, EventArgs e)
        {
            FrmSelectingComponent<PowerSource> selectingComponent = new FrmSelectingComponent<PowerSource>(Factory.SecondaryStock.Filter<PowerSource>());

            selectingComponent.ShowDialog();

            this.txtDescription.Visible = true;
            this.lblDescription.Visible = true;
            this.lblColor.Visible = true;
            this.txtColor.Visible = true;

            try
            {

                if (selectingComponent.DialogResult == DialogResult.Cancel)
                {
                    this.computer.PowerSource = selectingComponent.Return;
                    if (!(this.computer.PowerSource is null))
                    {
                        this.rtbCurrentAssembling.Text += this.computer.PowerSource.ToString();
                        this.btnAssembleProduct.Visible = true;
                    }
                    else
                    {
                        throw new MissingComponentException("Factory cannot assemble this product without a Power Source");
                    }
                }
            }
            catch (MissingComponentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Start the selecting process of a Graphic Card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssembleGraphicCard_Click(object sender, EventArgs e)
        {
            FrmSelectingComponent<GraphicCard> selectingComponent = new FrmSelectingComponent<GraphicCard>(Factory.SecondaryStock.Filter<GraphicCard>());

            selectingComponent.ShowDialog();

            this.btnAssemblePowerSource.Visible = true;

            try
            {

                if (selectingComponent.DialogResult == DialogResult.Cancel)
                {
                    this.computer.Motherboard.GraphicCard = selectingComponent.Return;
                    if (!(this.computer.Motherboard.GraphicCard is null))
                    {
                        this.rtbCurrentAssembling.Text += this.computer.Motherboard.GraphicCard.ToString();

                    }
                    else
                    {
                        throw new MissingComponentException("Factory cannot assemble this product without a Graphic Card");
                    }
                }
            }
            catch (MissingComponentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Finish the process of assembling a Product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAssembleProduct_Click(object sender, EventArgs e)
        {
            if (this.btnAssemblePC.Visible)
            {

                try
                {

                    if (!(this.computer.Motherboard is null) &&
                        !(this.computer.PowerSource is null) &&
                        !(this.computer.Motherboard.Processor is null) &&
                        !(this.computer.Motherboard.Ram is null) &&
                        !(this.pc.Gabinet is null) &&
                        !(this.computer.Motherboard.GraphicCard is null))
                    {
                        this.pc.Description = this.txtDescription.Text;
                        this.pc.Color = this.txtColor.Text;
                        this.pc.IdProduct = Assembler.GenerateGuid();
                        this.pc.SerialNumber = Assembler.GenerateSerialNumber();
                        this.pc.AddComputer = this.computer;
                        Factory.NewProduct += this.RefreshList;
                        Factory.AddToPrimaryStock(this.pc);
                        Factory.SaveCurrentStock("C:\\Users\\PC\\Desktop\\tp_laboratorio_2\\Diaz.Iosu.2C.TPFinal\\productos.xml", "C:\\Users\\PC\\Desktop\\tp_laboratorio_2\\Diaz.Iosu.2C.TPFinal\\componentes.xml");
                        this.SaveToDB(this.pc);
                        this.rtbCurrentAssembling.Text = "";
                        this.btnAssembleNotebook.Visible = true;
                        this.HideButtons();
                        
                    }
                    else
                    {
                        throw new MissingComponentException("There are missing components to assemble this product");
                    }
                }
                catch (MissingComponentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.notebook.Description = this.txtDescription.Text;
                this.notebook.Color = this.txtColor.Text;

                try
                {

                    if (!(this.computer.Motherboard is null) &&
                        !(this.computer.PowerSource is null) &&
                        !(this.computer.Motherboard.Processor is null) &&
                        !(this.computer.Motherboard.Ram is null) &&
                        !(this.notebook.Display is null) &&
                        !(this.computer.Motherboard.GraphicCard is null))
                    {
                        this.notebook.IdProduct = Assembler.GenerateGuid();
                        this.notebook.SerialNumber = Assembler.GenerateSerialNumber();
                        this.notebook.AddComputer = this.computer;
                        Factory.NewProduct += this.RefreshList;
                        Factory.AddToPrimaryStock(this.notebook);
                        Factory.SaveCurrentStock("C:\\Users\\PC\\Desktop\\tp_laboratorio_2\\Diaz.Iosu.2C.TPFinal\\productos.xml", "C:\\Users\\PC\\Desktop\\tp_laboratorio_2\\Diaz.Iosu.2C.TPFinal\\componentes.xml");
                        this.SaveToDB(this.notebook);
                        this.rtbCurrentAssembling.Text = "";
                        this.btnAssemblePC.Visible = true;
                        this.HideButtons();
                        
                    }
                    else
                    {
                        throw new MissingComponentException("There are missing components to assemble this product");
                    }
                }
                catch (MissingComponentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// Refreshes the product list
        /// </summary>
        /// <param name="product"></param>
        private void RefreshList(Product product)
        {
            this.rtbListaProductos.Text += product;
        }
        /// <summary>
        /// Leaves the first buttons visible and the others unvisible
        /// </summary>
        private void HideButtons()
        {
            this.btnAssemblePC.Visible = true;
            this.btnAssembleNotebook.Visible = true;
            this.lblSelectComponents.Visible = false;
            this.btnAssembleGraphicCard.Visible = false;
            this.btnAssembleMotherboard.Visible = false;
            this.btnAssemblePowerSource.Visible = false;
            this.btnAssembleProcessor.Visible = false;
            this.btnAssembleRam.Visible = false;
            this.lblDescription.Visible = false;
            this.txtDescription.Visible = false;
            this.btnAssembleProduct.Visible = false;
            this.lblColor.Visible = false;
            this.txtColor.Visible = false;
        }
        /// <summary>
        /// Cancels the process of assembling a Product 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAssembling_Click(object sender, EventArgs e)
        {
            this.pc = null;
            this.notebook = null;
            this.computer = null;
            this.HideButtons();
            Thread thread = new Thread(CleanCurrentAssemblingInfo);
            thread.Start();

        }
        /// <summary>
        /// Cleans the richTextBox which display the assembling data
        /// </summary>
        private void CleanCurrentAssemblingInfo()
        {
            if (this.rtbCurrentAssembling.InvokeRequired)
            {
                ClearUsedData a = new ClearUsedData(this.CleanCurrentAssemblingInfo);
                this.Invoke(a);
            }
            else
            {
                this.rtbCurrentAssembling.Text = "";
            }
        }
        /// <summary>
        /// Saves to the DataBase the product assembled
        /// </summary>
        /// <param name="product"></param>
        private void SaveToDB(Product product)
        {
            SqlConnection conexionBD = new SqlConnection("Data Source=.;Initial Catalog=Diaz.Iosu.2C.TPFinal;Integrated Security=True;");
            SqlCommand comando = new SqlCommand();

            comando.Connection = conexionBD;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO dbo.Products VALUES(@description,@idProduct,@serialNumber,@color)";
            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@description", product.Description);
            comando.Parameters.AddWithValue("@idProduct", product.IdProduct);
            comando.Parameters.AddWithValue("@serialNumber", product.SerialNumber);
            comando.Parameters.AddWithValue("@color", product.Color);

            conexionBD.Open();

            comando.ExecuteNonQuery();


            if (conexionBD.State == ConnectionState.Open)
            {

                conexionBD.Close();
            }


        }
    }
}


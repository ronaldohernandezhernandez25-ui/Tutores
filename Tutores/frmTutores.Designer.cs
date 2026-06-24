namespace Tutores
{
    partial class frmtutores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtutores));
            lblTitulo = new Label();
            pnlTutores = new Panel();
            txtTelefonoTutor = new TextBox();
            txtEmailTutor = new TextBox();
            txtDireccionTutor = new TextBox();
            txtNombreTutor = new TextBox();
            txtPrentescoTutor = new TextBox();
            button1 = new Button();
            btnEliminarTutor = new Button();
            btnNuevoTutor = new Button();
            dgvTutores = new DataGridView();
            txtBuscarTutor = new TextBox();
            pnlTutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Book Antiqua", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(567, 37);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(242, 73);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Tutores";
            // 
            // pnlTutores
            // 
            pnlTutores.Controls.Add(txtTelefonoTutor);
            pnlTutores.Controls.Add(txtEmailTutor);
            pnlTutores.Controls.Add(txtDireccionTutor);
            pnlTutores.Controls.Add(txtNombreTutor);
            pnlTutores.Controls.Add(txtPrentescoTutor);
            pnlTutores.Controls.Add(button1);
            pnlTutores.Controls.Add(btnEliminarTutor);
            pnlTutores.Controls.Add(btnNuevoTutor);
            pnlTutores.Location = new Point(174, 127);
            pnlTutores.Name = "pnlTutores";
            pnlTutores.Size = new Size(998, 391);
            pnlTutores.TabIndex = 1;
            // 
            // txtTelefonoTutor
            // 
            txtTelefonoTutor.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefonoTutor.Location = new Point(208, 190);
            txtTelefonoTutor.Name = "txtTelefonoTutor";
            txtTelefonoTutor.PlaceholderText = "Ingrese el telefono del tutor";
            txtTelefonoTutor.Size = new Size(607, 36);
            txtTelefonoTutor.TabIndex = 8;
            // 
            // txtEmailTutor
            // 
            txtEmailTutor.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailTutor.Location = new Point(208, 246);
            txtEmailTutor.Name = "txtEmailTutor";
            txtEmailTutor.PlaceholderText = "Ingrese el email del tutor";
            txtEmailTutor.Size = new Size(607, 36);
            txtEmailTutor.TabIndex = 7;
            // 
            // txtDireccionTutor
            // 
            txtDireccionTutor.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDireccionTutor.Location = new Point(208, 140);
            txtDireccionTutor.Name = "txtDireccionTutor";
            txtDireccionTutor.PlaceholderText = "Ingrese la direccion del tutor";
            txtDireccionTutor.Size = new Size(607, 36);
            txtDireccionTutor.TabIndex = 6;
            // 
            // txtNombreTutor
            // 
            txtNombreTutor.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreTutor.Location = new Point(208, 25);
            txtNombreTutor.Name = "txtNombreTutor";
            txtNombreTutor.PlaceholderText = "Ingrese el nombre completo del tutor";
            txtNombreTutor.Size = new Size(607, 36);
            txtNombreTutor.TabIndex = 5;
            // 
            // txtPrentescoTutor
            // 
            txtPrentescoTutor.Font = new Font("Book Antiqua", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrentescoTutor.Location = new Point(208, 84);
            txtPrentescoTutor.Name = "txtPrentescoTutor";
            txtPrentescoTutor.PlaceholderText = "Ingrese el parentesco";
            txtPrentescoTutor.Size = new Size(607, 36);
            txtPrentescoTutor.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(436, 307);
            button1.Name = "button1";
            button1.Size = new Size(147, 69);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnEliminarTutor
            // 
            btnEliminarTutor.BackgroundImage = (Image)resources.GetObject("btnEliminarTutor.BackgroundImage");
            btnEliminarTutor.BackgroundImageLayout = ImageLayout.Stretch;
            btnEliminarTutor.Location = new Point(668, 307);
            btnEliminarTutor.Name = "btnEliminarTutor";
            btnEliminarTutor.Size = new Size(147, 69);
            btnEliminarTutor.TabIndex = 2;
            btnEliminarTutor.UseVisualStyleBackColor = true;
            // 
            // btnNuevoTutor
            // 
            btnNuevoTutor.BackgroundImage = (Image)resources.GetObject("btnNuevoTutor.BackgroundImage");
            btnNuevoTutor.BackgroundImageLayout = ImageLayout.Stretch;
            btnNuevoTutor.Location = new Point(208, 307);
            btnNuevoTutor.Name = "btnNuevoTutor";
            btnNuevoTutor.Size = new Size(147, 69);
            btnNuevoTutor.TabIndex = 0;
            btnNuevoTutor.UseVisualStyleBackColor = true;
            // 
            // dgvTutores
            // 
            dgvTutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTutores.Location = new Point(115, 569);
            dgvTutores.Name = "dgvTutores";
            dgvTutores.RowHeadersWidth = 51;
            dgvTutores.Size = new Size(1126, 188);
            dgvTutores.TabIndex = 2;
            // 
            // txtBuscarTutor
            // 
            txtBuscarTutor.Font = new Font("Book Antiqua", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscarTutor.Location = new Point(1006, 524);
            txtBuscarTutor.Name = "txtBuscarTutor";
            txtBuscarTutor.PlaceholderText = "Buscar Tutor";
            txtBuscarTutor.Size = new Size(166, 39);
            txtBuscarTutor.TabIndex = 3;
            // 
            // frmtutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1366, 801);
            Controls.Add(txtBuscarTutor);
            Controls.Add(dgvTutores);
            Controls.Add(pnlTutores);
            Controls.Add(lblTitulo);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Name = "frmtutores";
            Text = "Tutores";
            pnlTutores.ResumeLayout(false);
            pnlTutores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Panel pnlTutores;
        private Button btnEliminarTutor;
        private Button btnNuevoTutor;
        private DataGridView dgvTutores;
        private Button button1;
        private TextBox txtTelefonoTutor;
        private TextBox txtEmailTutor;
        private TextBox txtDireccionTutor;
        private TextBox txtNombreTutor;
        private TextBox txtPrentescoTutor;
        private TextBox txtBuscarTutor;
    }
}

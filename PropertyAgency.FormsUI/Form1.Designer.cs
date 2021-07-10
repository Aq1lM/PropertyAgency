
namespace PropertyAgency.FormsUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwHouses = new System.Windows.Forms.DataGridView();
            this.gbxCrud = new System.Windows.Forms.GroupBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxCustomerIdUpdate = new System.Windows.Forms.TextBox();
            this.tbxCityIdUpdate = new System.Windows.Forms.TextBox();
            this.tbxAreaUpdate = new System.Windows.Forms.TextBox();
            this.tbxKindIdUpdate = new System.Windows.Forms.TextBox();
            this.tbxFloorUpdate = new System.Windows.Forms.TextBox();
            this.tbxPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxRoomsUpdate = new System.Windows.Forms.TextBox();
            this.tbxAdressUpdate = new System.Windows.Forms.TextBox();
            this.lblCustomerIdUpdate = new System.Windows.Forms.Label();
            this.lblAreaUpdate = new System.Windows.Forms.Label();
            this.lblKindIdUpdate = new System.Windows.Forms.Label();
            this.lblRoomsUpdate = new System.Windows.Forms.Label();
            this.lblCityIdUpdate = new System.Windows.Forms.Label();
            this.lblFloorUpdate = new System.Windows.Forms.Label();
            this.lblPriceUpdate = new System.Windows.Forms.Label();
            this.lblAdressUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxCustomerIdAdd = new System.Windows.Forms.TextBox();
            this.tbxCityIdAdd = new System.Windows.Forms.TextBox();
            this.tbxAreaAdd = new System.Windows.Forms.TextBox();
            this.tbxKindIdAdd = new System.Windows.Forms.TextBox();
            this.tbxFloorAdd = new System.Windows.Forms.TextBox();
            this.tbxPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxRoomsAdd = new System.Windows.Forms.TextBox();
            this.tbxAdressAdd = new System.Windows.Forms.TextBox();
            this.lblCustomerIdAdd = new System.Windows.Forms.Label();
            this.lblAreaAdd = new System.Windows.Forms.Label();
            this.lblKindIdAdd = new System.Windows.Forms.Label();
            this.lblRoomsAdd = new System.Windows.Forms.Label();
            this.lblCityIdAdd = new System.Windows.Forms.Label();
            this.lblFloorAdd = new System.Windows.Forms.Label();
            this.lblPriceAdd = new System.Windows.Forms.Label();
            this.lblAdressAdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHouses)).BeginInit();
            this.gbxCrud.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwHouses
            // 
            this.dgwHouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHouses.Location = new System.Drawing.Point(12, 39);
            this.dgwHouses.Name = "dgwHouses";
            this.dgwHouses.Size = new System.Drawing.Size(1266, 314);
            this.dgwHouses.TabIndex = 0;
            this.dgwHouses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHouses_CellClick);
            // 
            // gbxCrud
            // 
            this.gbxCrud.Controls.Add(this.gbxUpdate);
            this.gbxCrud.Controls.Add(this.gbxAdd);
            this.gbxCrud.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCrud.Location = new System.Drawing.Point(12, 374);
            this.gbxCrud.Name = "gbxCrud";
            this.gbxCrud.Size = new System.Drawing.Size(726, 449);
            this.gbxCrud.TabIndex = 1;
            this.gbxCrud.TabStop = false;
            this.gbxCrud.Text = "CRUD";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnDelete);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxCustomerIdUpdate);
            this.gbxUpdate.Controls.Add(this.tbxCityIdUpdate);
            this.gbxUpdate.Controls.Add(this.tbxAreaUpdate);
            this.gbxUpdate.Controls.Add(this.tbxKindIdUpdate);
            this.gbxUpdate.Controls.Add(this.tbxFloorUpdate);
            this.gbxUpdate.Controls.Add(this.tbxPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxRoomsUpdate);
            this.gbxUpdate.Controls.Add(this.tbxAdressUpdate);
            this.gbxUpdate.Controls.Add(this.lblCustomerIdUpdate);
            this.gbxUpdate.Controls.Add(this.lblAreaUpdate);
            this.gbxUpdate.Controls.Add(this.lblKindIdUpdate);
            this.gbxUpdate.Controls.Add(this.lblRoomsUpdate);
            this.gbxUpdate.Controls.Add(this.lblCityIdUpdate);
            this.gbxUpdate.Controls.Add(this.lblFloorUpdate);
            this.gbxUpdate.Controls.Add(this.lblPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblAdressUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdate.Location = new System.Drawing.Point(365, 31);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(344, 412);
            this.gbxUpdate.TabIndex = 0;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(169, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(169, 336);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 31);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxCustomerIdUpdate
            // 
            this.tbxCustomerIdUpdate.Location = new System.Drawing.Point(146, 301);
            this.tbxCustomerIdUpdate.Name = "tbxCustomerIdUpdate";
            this.tbxCustomerIdUpdate.Size = new System.Drawing.Size(169, 29);
            this.tbxCustomerIdUpdate.TabIndex = 1;
            // 
            // tbxCityIdUpdate
            // 
            this.tbxCityIdUpdate.Location = new System.Drawing.Point(146, 262);
            this.tbxCityIdUpdate.Name = "tbxCityIdUpdate";
            this.tbxCityIdUpdate.Size = new System.Drawing.Size(169, 29);
            this.tbxCityIdUpdate.TabIndex = 1;
            // 
            // tbxAreaUpdate
            // 
            this.tbxAreaUpdate.Location = new System.Drawing.Point(146, 146);
            this.tbxAreaUpdate.Name = "tbxAreaUpdate";
            this.tbxAreaUpdate.Size = new System.Drawing.Size(169, 29);
            this.tbxAreaUpdate.TabIndex = 1;
            // 
            // tbxKindIdUpdate
            // 
            this.tbxKindIdUpdate.Location = new System.Drawing.Point(146, 223);
            this.tbxKindIdUpdate.Name = "tbxKindIdUpdate";
            this.tbxKindIdUpdate.Size = new System.Drawing.Size(169, 29);
            this.tbxKindIdUpdate.TabIndex = 1;
            // 
            // tbxFloorUpdate
            // 
            this.tbxFloorUpdate.Location = new System.Drawing.Point(146, 110);
            this.tbxFloorUpdate.Name = "tbxFloorUpdate";
            this.tbxFloorUpdate.Size = new System.Drawing.Size(169, 29);
            this.tbxFloorUpdate.TabIndex = 1;
            // 
            // tbxPriceUpdate
            // 
            this.tbxPriceUpdate.Location = new System.Drawing.Point(146, 183);
            this.tbxPriceUpdate.Name = "tbxPriceUpdate";
            this.tbxPriceUpdate.Size = new System.Drawing.Size(169, 29);
            this.tbxPriceUpdate.TabIndex = 1;
            // 
            // tbxRoomsUpdate
            // 
            this.tbxRoomsUpdate.Location = new System.Drawing.Point(146, 72);
            this.tbxRoomsUpdate.Name = "tbxRoomsUpdate";
            this.tbxRoomsUpdate.Size = new System.Drawing.Size(169, 29);
            this.tbxRoomsUpdate.TabIndex = 1;
            // 
            // tbxAdressUpdate
            // 
            this.tbxAdressUpdate.Location = new System.Drawing.Point(146, 35);
            this.tbxAdressUpdate.Name = "tbxAdressUpdate";
            this.tbxAdressUpdate.Size = new System.Drawing.Size(169, 29);
            this.tbxAdressUpdate.TabIndex = 1;
            // 
            // lblCustomerIdUpdate
            // 
            this.lblCustomerIdUpdate.AutoSize = true;
            this.lblCustomerIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerIdUpdate.Location = new System.Drawing.Point(24, 307);
            this.lblCustomerIdUpdate.Name = "lblCustomerIdUpdate";
            this.lblCustomerIdUpdate.Size = new System.Drawing.Size(92, 20);
            this.lblCustomerIdUpdate.TabIndex = 0;
            this.lblCustomerIdUpdate.Text = "CustomerId";
            // 
            // lblAreaUpdate
            // 
            this.lblAreaUpdate.AutoSize = true;
            this.lblAreaUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaUpdate.Location = new System.Drawing.Point(24, 152);
            this.lblAreaUpdate.Name = "lblAreaUpdate";
            this.lblAreaUpdate.Size = new System.Drawing.Size(43, 20);
            this.lblAreaUpdate.TabIndex = 0;
            this.lblAreaUpdate.Text = "Area";
            // 
            // lblKindIdUpdate
            // 
            this.lblKindIdUpdate.AutoSize = true;
            this.lblKindIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKindIdUpdate.Location = new System.Drawing.Point(24, 229);
            this.lblKindIdUpdate.Name = "lblKindIdUpdate";
            this.lblKindIdUpdate.Size = new System.Drawing.Size(58, 20);
            this.lblKindIdUpdate.TabIndex = 0;
            this.lblKindIdUpdate.Text = "Kind Id";
            // 
            // lblRoomsUpdate
            // 
            this.lblRoomsUpdate.AutoSize = true;
            this.lblRoomsUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomsUpdate.Location = new System.Drawing.Point(24, 78);
            this.lblRoomsUpdate.Name = "lblRoomsUpdate";
            this.lblRoomsUpdate.Size = new System.Drawing.Size(60, 20);
            this.lblRoomsUpdate.TabIndex = 0;
            this.lblRoomsUpdate.Text = "Rooms";
            // 
            // lblCityIdUpdate
            // 
            this.lblCityIdUpdate.AutoSize = true;
            this.lblCityIdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityIdUpdate.Location = new System.Drawing.Point(24, 268);
            this.lblCityIdUpdate.Name = "lblCityIdUpdate";
            this.lblCityIdUpdate.Size = new System.Drawing.Size(49, 20);
            this.lblCityIdUpdate.TabIndex = 0;
            this.lblCityIdUpdate.Text = "CityId";
            // 
            // lblFloorUpdate
            // 
            this.lblFloorUpdate.AutoSize = true;
            this.lblFloorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloorUpdate.Location = new System.Drawing.Point(24, 116);
            this.lblFloorUpdate.Name = "lblFloorUpdate";
            this.lblFloorUpdate.Size = new System.Drawing.Size(45, 20);
            this.lblFloorUpdate.TabIndex = 0;
            this.lblFloorUpdate.Text = "Floor";
            // 
            // lblPriceUpdate
            // 
            this.lblPriceUpdate.AutoSize = true;
            this.lblPriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceUpdate.Location = new System.Drawing.Point(24, 189);
            this.lblPriceUpdate.Name = "lblPriceUpdate";
            this.lblPriceUpdate.Size = new System.Drawing.Size(44, 20);
            this.lblPriceUpdate.TabIndex = 0;
            this.lblPriceUpdate.Text = "Price";
            // 
            // lblAdressUpdate
            // 
            this.lblAdressUpdate.AutoSize = true;
            this.lblAdressUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdressUpdate.Location = new System.Drawing.Point(24, 41);
            this.lblAdressUpdate.Name = "lblAdressUpdate";
            this.lblAdressUpdate.Size = new System.Drawing.Size(59, 20);
            this.lblAdressUpdate.TabIndex = 0;
            this.lblAdressUpdate.Text = "Adress";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxCustomerIdAdd);
            this.gbxAdd.Controls.Add(this.tbxCityIdAdd);
            this.gbxAdd.Controls.Add(this.tbxAreaAdd);
            this.gbxAdd.Controls.Add(this.tbxKindIdAdd);
            this.gbxAdd.Controls.Add(this.tbxFloorAdd);
            this.gbxAdd.Controls.Add(this.tbxPriceAdd);
            this.gbxAdd.Controls.Add(this.tbxRoomsAdd);
            this.gbxAdd.Controls.Add(this.tbxAdressAdd);
            this.gbxAdd.Controls.Add(this.lblCustomerIdAdd);
            this.gbxAdd.Controls.Add(this.lblAreaAdd);
            this.gbxAdd.Controls.Add(this.lblKindIdAdd);
            this.gbxAdd.Controls.Add(this.lblRoomsAdd);
            this.gbxAdd.Controls.Add(this.lblCityIdAdd);
            this.gbxAdd.Controls.Add(this.lblFloorAdd);
            this.gbxAdd.Controls.Add(this.lblPriceAdd);
            this.gbxAdd.Controls.Add(this.lblAdressAdd);
            this.gbxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAdd.Location = new System.Drawing.Point(15, 31);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(344, 412);
            this.gbxAdd.TabIndex = 0;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(172, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxCustomerIdAdd
            // 
            this.tbxCustomerIdAdd.Location = new System.Drawing.Point(146, 301);
            this.tbxCustomerIdAdd.Name = "tbxCustomerIdAdd";
            this.tbxCustomerIdAdd.Size = new System.Drawing.Size(169, 29);
            this.tbxCustomerIdAdd.TabIndex = 1;
            // 
            // tbxCityIdAdd
            // 
            this.tbxCityIdAdd.Location = new System.Drawing.Point(146, 262);
            this.tbxCityIdAdd.Name = "tbxCityIdAdd";
            this.tbxCityIdAdd.Size = new System.Drawing.Size(169, 29);
            this.tbxCityIdAdd.TabIndex = 1;
            // 
            // tbxAreaAdd
            // 
            this.tbxAreaAdd.Location = new System.Drawing.Point(146, 146);
            this.tbxAreaAdd.Name = "tbxAreaAdd";
            this.tbxAreaAdd.Size = new System.Drawing.Size(169, 29);
            this.tbxAreaAdd.TabIndex = 1;
            // 
            // tbxKindIdAdd
            // 
            this.tbxKindIdAdd.Location = new System.Drawing.Point(146, 223);
            this.tbxKindIdAdd.Name = "tbxKindIdAdd";
            this.tbxKindIdAdd.Size = new System.Drawing.Size(169, 29);
            this.tbxKindIdAdd.TabIndex = 1;
            // 
            // tbxFloorAdd
            // 
            this.tbxFloorAdd.Location = new System.Drawing.Point(146, 110);
            this.tbxFloorAdd.Name = "tbxFloorAdd";
            this.tbxFloorAdd.Size = new System.Drawing.Size(169, 29);
            this.tbxFloorAdd.TabIndex = 1;
            // 
            // tbxPriceAdd
            // 
            this.tbxPriceAdd.Location = new System.Drawing.Point(146, 183);
            this.tbxPriceAdd.Name = "tbxPriceAdd";
            this.tbxPriceAdd.Size = new System.Drawing.Size(169, 29);
            this.tbxPriceAdd.TabIndex = 1;
            // 
            // tbxRoomsAdd
            // 
            this.tbxRoomsAdd.Location = new System.Drawing.Point(146, 72);
            this.tbxRoomsAdd.Name = "tbxRoomsAdd";
            this.tbxRoomsAdd.Size = new System.Drawing.Size(169, 29);
            this.tbxRoomsAdd.TabIndex = 1;
            // 
            // tbxAdressAdd
            // 
            this.tbxAdressAdd.Location = new System.Drawing.Point(146, 35);
            this.tbxAdressAdd.Name = "tbxAdressAdd";
            this.tbxAdressAdd.Size = new System.Drawing.Size(169, 29);
            this.tbxAdressAdd.TabIndex = 1;
            // 
            // lblCustomerIdAdd
            // 
            this.lblCustomerIdAdd.AutoSize = true;
            this.lblCustomerIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerIdAdd.Location = new System.Drawing.Point(24, 307);
            this.lblCustomerIdAdd.Name = "lblCustomerIdAdd";
            this.lblCustomerIdAdd.Size = new System.Drawing.Size(92, 20);
            this.lblCustomerIdAdd.TabIndex = 0;
            this.lblCustomerIdAdd.Text = "CustomerId";
            // 
            // lblAreaAdd
            // 
            this.lblAreaAdd.AutoSize = true;
            this.lblAreaAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaAdd.Location = new System.Drawing.Point(24, 152);
            this.lblAreaAdd.Name = "lblAreaAdd";
            this.lblAreaAdd.Size = new System.Drawing.Size(43, 20);
            this.lblAreaAdd.TabIndex = 0;
            this.lblAreaAdd.Text = "Area";
            // 
            // lblKindIdAdd
            // 
            this.lblKindIdAdd.AutoSize = true;
            this.lblKindIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKindIdAdd.Location = new System.Drawing.Point(24, 229);
            this.lblKindIdAdd.Name = "lblKindIdAdd";
            this.lblKindIdAdd.Size = new System.Drawing.Size(58, 20);
            this.lblKindIdAdd.TabIndex = 0;
            this.lblKindIdAdd.Text = "Kind Id";
            // 
            // lblRoomsAdd
            // 
            this.lblRoomsAdd.AutoSize = true;
            this.lblRoomsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomsAdd.Location = new System.Drawing.Point(24, 78);
            this.lblRoomsAdd.Name = "lblRoomsAdd";
            this.lblRoomsAdd.Size = new System.Drawing.Size(60, 20);
            this.lblRoomsAdd.TabIndex = 0;
            this.lblRoomsAdd.Text = "Rooms";
            // 
            // lblCityIdAdd
            // 
            this.lblCityIdAdd.AutoSize = true;
            this.lblCityIdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityIdAdd.Location = new System.Drawing.Point(24, 268);
            this.lblCityIdAdd.Name = "lblCityIdAdd";
            this.lblCityIdAdd.Size = new System.Drawing.Size(49, 20);
            this.lblCityIdAdd.TabIndex = 0;
            this.lblCityIdAdd.Text = "CityId";
            // 
            // lblFloorAdd
            // 
            this.lblFloorAdd.AutoSize = true;
            this.lblFloorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloorAdd.Location = new System.Drawing.Point(24, 116);
            this.lblFloorAdd.Name = "lblFloorAdd";
            this.lblFloorAdd.Size = new System.Drawing.Size(45, 20);
            this.lblFloorAdd.TabIndex = 0;
            this.lblFloorAdd.Text = "Floor";
            // 
            // lblPriceAdd
            // 
            this.lblPriceAdd.AutoSize = true;
            this.lblPriceAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceAdd.Location = new System.Drawing.Point(24, 189);
            this.lblPriceAdd.Name = "lblPriceAdd";
            this.lblPriceAdd.Size = new System.Drawing.Size(44, 20);
            this.lblPriceAdd.TabIndex = 0;
            this.lblPriceAdd.Text = "Price";
            // 
            // lblAdressAdd
            // 
            this.lblAdressAdd.AutoSize = true;
            this.lblAdressAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdressAdd.Location = new System.Drawing.Point(24, 41);
            this.lblAdressAdd.Name = "lblAdressAdd";
            this.lblAdressAdd.Size = new System.Drawing.Size(59, 20);
            this.lblAdressAdd.TabIndex = 0;
            this.lblAdressAdd.Text = "Adress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 835);
            this.Controls.Add(this.gbxCrud);
            this.Controls.Add(this.dgwHouses);
            this.Name = "Form1";
            this.Text = "Property Agency";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHouses)).EndInit();
            this.gbxCrud.ResumeLayout(false);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwHouses;
        private System.Windows.Forms.GroupBox gbxCrud;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxCustomerIdAdd;
        private System.Windows.Forms.TextBox tbxCityIdAdd;
        private System.Windows.Forms.TextBox tbxAreaAdd;
        private System.Windows.Forms.TextBox tbxKindIdAdd;
        private System.Windows.Forms.TextBox tbxFloorAdd;
        private System.Windows.Forms.TextBox tbxPriceAdd;
        private System.Windows.Forms.TextBox tbxRoomsAdd;
        private System.Windows.Forms.TextBox tbxAdressAdd;
        private System.Windows.Forms.Label lblCustomerIdAdd;
        private System.Windows.Forms.Label lblAreaAdd;
        private System.Windows.Forms.Label lblKindIdAdd;
        private System.Windows.Forms.Label lblRoomsAdd;
        private System.Windows.Forms.Label lblCityIdAdd;
        private System.Windows.Forms.Label lblFloorAdd;
        private System.Windows.Forms.Label lblPriceAdd;
        private System.Windows.Forms.Label lblAdressAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxCustomerIdUpdate;
        private System.Windows.Forms.TextBox tbxCityIdUpdate;
        private System.Windows.Forms.TextBox tbxAreaUpdate;
        private System.Windows.Forms.TextBox tbxKindIdUpdate;
        private System.Windows.Forms.TextBox tbxFloorUpdate;
        private System.Windows.Forms.TextBox tbxPriceUpdate;
        private System.Windows.Forms.TextBox tbxRoomsUpdate;
        private System.Windows.Forms.TextBox tbxAdressUpdate;
        private System.Windows.Forms.Label lblCustomerIdUpdate;
        private System.Windows.Forms.Label lblAreaUpdate;
        private System.Windows.Forms.Label lblKindIdUpdate;
        private System.Windows.Forms.Label lblRoomsUpdate;
        private System.Windows.Forms.Label lblCityIdUpdate;
        private System.Windows.Forms.Label lblFloorUpdate;
        private System.Windows.Forms.Label lblPriceUpdate;
        private System.Windows.Forms.Label lblAdressUpdate;
    }
}


namespace RoomBuilder
{
    partial class NewItem
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblDescr = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.txtArmor = new System.Windows.Forms.TextBox();
            this.lblArmor = new System.Windows.Forms.Label();
            this.lblRestore = new System.Windows.Forms.Label();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.lblDecrease = new System.Windows.Forms.Label();
            this.txtDecrease = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.cmbKey = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(12, 9);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(68, 25);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(86, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 31);
            this.txtName.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(12, 65);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(60, 25);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Weapon",
            "Armor",
            "Healing",
            "Damage",
            "Key"});
            this.cmbType.Location = new System.Drawing.Point(86, 62);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(236, 33);
            this.cmbType.TabIndex = 3;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescr.Location = new System.Drawing.Point(12, 124);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(120, 25);
            this.lblDescr.TabIndex = 4;
            this.lblDescr.Text = "Description";
            // 
            // txtDescr
            // 
            this.txtDescr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescr.Location = new System.Drawing.Point(17, 153);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(305, 31);
            this.txtDescr.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(70, 464);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(174, 36);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create Item";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeapon.Location = new System.Drawing.Point(17, 225);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(92, 25);
            this.lblWeapon.TabIndex = 7;
            this.lblWeapon.Text = "Damage";
            // 
            // txtWeapon
            // 
            this.txtWeapon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeapon.Location = new System.Drawing.Point(115, 222);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(100, 31);
            this.txtWeapon.TabIndex = 8;
            // 
            // txtArmor
            // 
            this.txtArmor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArmor.Location = new System.Drawing.Point(115, 222);
            this.txtArmor.Name = "txtArmor";
            this.txtArmor.Size = new System.Drawing.Size(100, 31);
            this.txtArmor.TabIndex = 9;
            // 
            // lblArmor
            // 
            this.lblArmor.AutoSize = true;
            this.lblArmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArmor.Location = new System.Drawing.Point(17, 224);
            this.lblArmor.Name = "lblArmor";
            this.lblArmor.Size = new System.Drawing.Size(92, 25);
            this.lblArmor.TabIndex = 10;
            this.lblArmor.Text = "Defense";
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestore.Location = new System.Drawing.Point(17, 225);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(162, 25);
            this.lblRestore.TabIndex = 11;
            this.lblRestore.Text = "Health Increase";
            // 
            // txtRestore
            // 
            this.txtRestore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestore.Location = new System.Drawing.Point(185, 222);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(100, 31);
            this.txtRestore.TabIndex = 12;
            // 
            // lblDecrease
            // 
            this.lblDecrease.AutoSize = true;
            this.lblDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrease.Location = new System.Drawing.Point(17, 224);
            this.lblDecrease.Name = "lblDecrease";
            this.lblDecrease.Size = new System.Drawing.Size(172, 25);
            this.lblDecrease.TabIndex = 13;
            this.lblDecrease.Text = "Health Decrease";
            // 
            // txtDecrease
            // 
            this.txtDecrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecrease.Location = new System.Drawing.Point(194, 222);
            this.txtDecrease.Name = "txtDecrease";
            this.txtDecrease.Size = new System.Drawing.Size(100, 31);
            this.txtDecrease.TabIndex = 14;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(17, 224);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(171, 25);
            this.lblKey.TabIndex = 15;
            this.lblKey.Text = "Room To Unlock";
            // 
            // cmbKey
            // 
            this.cmbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKey.FormattingEnabled = true;
            this.cmbKey.Location = new System.Drawing.Point(195, 222);
            this.cmbKey.Name = "cmbKey";
            this.cmbKey.Size = new System.Drawing.Size(121, 33);
            this.cmbKey.TabIndex = 16;
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 512);
            this.Controls.Add(this.cmbKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtDecrease);
            this.Controls.Add(this.lblDecrease);
            this.Controls.Add(this.txtRestore);
            this.Controls.Add(this.lblRestore);
            this.Controls.Add(this.lblArmor);
            this.Controls.Add(this.txtArmor);
            this.Controls.Add(this.txtWeapon);
            this.Controls.Add(this.lblWeapon);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.lblDescr);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblItemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewItem";
            this.Text = "Add a New Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.TextBox txtWeapon;
        private System.Windows.Forms.TextBox txtArmor;
        private System.Windows.Forms.Label lblArmor;
        private System.Windows.Forms.Label lblRestore;
        private System.Windows.Forms.TextBox txtRestore;
        private System.Windows.Forms.Label lblDecrease;
        private System.Windows.Forms.TextBox txtDecrease;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.ComboBox cmbKey;
    }
}
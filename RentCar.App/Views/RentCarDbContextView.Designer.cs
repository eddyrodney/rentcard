namespace RentCar.App.Views.RentCarDbContextView {
    partial class RentCarDbContextView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItemClientCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItemEmployeeCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItemRentCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItemFuelTypeCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItemVehicleCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItemVehicleBrandCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItemVehicleModelCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItemVehicleTypeCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItemInspectionCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarItemUserCollectionView = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarGroupViews = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowDrag = false;
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.Groups.Add(this.tileBarGroupViews);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(8, 6, 12, 6);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(29, 11, 29, 11);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar.SelectedItem = this.tileBarItemClientCollectionView;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.Size = new System.Drawing.Size(1024, 110);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.tileBarItemRentCollectionView);
            this.tileBarGroupTables.Items.Add(this.tileBarItemInspectionCollectionView);
            this.tileBarGroupTables.Items.Add(this.tileBarItemClientCollectionView);
            this.tileBarGroupTables.Items.Add(this.tileBarItemEmployeeCollectionView);
            this.tileBarGroupTables.Items.Add(this.tileBarItemVehicleCollectionView);
            this.tileBarGroupTables.Items.Add(this.tileBarItemVehicleBrandCollectionView);
            this.tileBarGroupTables.Items.Add(this.tileBarItemVehicleModelCollectionView);
            this.tileBarGroupTables.Items.Add(this.tileBarItemVehicleTypeCollectionView);
            this.tileBarGroupTables.Items.Add(this.tileBarItemFuelTypeCollectionView);
            this.tileBarGroupTables.Items.Add(this.tileBarItemUserCollectionView);

            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "Menú";
            // 
            // tileBarItemClientCollectionView
            // 
            this.tileBarItemClientCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tileBarItemClientCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItemClientCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement1.Text = "Clientes";
            this.tileBarItemClientCollectionView.Elements.Add(tileItemElement1);
            this.tileBarItemClientCollectionView.Name = "tileBarItemClientCollectionView";
            // 
            // tileBarItemEmployeeCollectionView
            // 
            this.tileBarItemEmployeeCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.tileBarItemEmployeeCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItemEmployeeCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement2.Text = "Empleados";
            this.tileBarItemEmployeeCollectionView.Elements.Add(tileItemElement2);
            this.tileBarItemEmployeeCollectionView.Name = "tileBarItemEmployeeCollectionView";
            // 
            // tileBarItemRentCollectionView
            // 
            this.tileBarItemRentCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(56)))));
            this.tileBarItemRentCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItemRentCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement3.Text = "Rentas";
            this.tileBarItemRentCollectionView.Elements.Add(tileItemElement3);
            this.tileBarItemRentCollectionView.Name = "tileBarItemRentCollectionView";
            // 
            // tileBarItemFuelTypeCollectionView
            // 
            this.tileBarItemFuelTypeCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.tileBarItemFuelTypeCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItemFuelTypeCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement4.Text = "Tipos de combustibles";
            this.tileBarItemFuelTypeCollectionView.Elements.Add(tileItemElement4);
            this.tileBarItemFuelTypeCollectionView.Name = "tileBarItemFuelTypeCollectionView";
            // 
            // tileBarItemVehicleCollectionView
            // 
            this.tileBarItemVehicleCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(112)))), ((int)(((byte)(56)))));
            this.tileBarItemVehicleCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItemVehicleCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement6.Text = "Vehículos";
            this.tileBarItemVehicleCollectionView.Elements.Add(tileItemElement6);
            this.tileBarItemVehicleCollectionView.Name = "tileBarItemVehicleCollectionView";
            // 
            // tileBarItemVehicleBrandCollectionView
            // 
            this.tileBarItemVehicleBrandCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.tileBarItemVehicleBrandCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItemVehicleBrandCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement7.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement7.Text = "Marcas de vehículos";
            this.tileBarItemVehicleBrandCollectionView.Elements.Add(tileItemElement7);
            this.tileBarItemVehicleBrandCollectionView.Name = "tileBarItemVehicleBrandCollectionView";
            // 
            // tileBarItemVehicleModelCollectionView
            // 
            this.tileBarItemVehicleModelCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tileBarItemVehicleModelCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItemVehicleModelCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement8.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement8.Text = "Modelos de vehículos";
            this.tileBarItemVehicleModelCollectionView.Elements.Add(tileItemElement8);
            this.tileBarItemVehicleModelCollectionView.Name = "tileBarItemVehicleModelCollectionView";
            // 
            // tileBarItemVehicleTypeCollectionView
            // 
            this.tileBarItemVehicleTypeCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.tileBarItemVehicleTypeCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItemVehicleTypeCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement9.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement9.Text = "Tipos de vehículos";
            this.tileBarItemVehicleTypeCollectionView.Elements.Add(tileItemElement9);
            this.tileBarItemVehicleTypeCollectionView.Name = "tileBarItemVehicleTypeCollectionView";
            // 
            // tileBarItemInspectionCollectionView
            // 
            this.tileBarItemInspectionCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.tileBarItemInspectionCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItemInspectionCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement5.Text = "Inspecciones";
            this.tileBarItemInspectionCollectionView.Elements.Add(tileItemElement5);
            this.tileBarItemInspectionCollectionView.Name = "tileBarItemInspectionCollectionView";
            // 
            // tileBarItemUserCollectionView
            // 
            this.tileBarItemUserCollectionView.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(156)))));
            this.tileBarItemUserCollectionView.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItemUserCollectionView.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement10.ImageUri.Uri = "Cube;Size32x32;GrayScaled";
            tileItemElement10.Text = "Usuarios";
            this.tileBarItemUserCollectionView.Elements.Add(tileItemElement10);
            this.tileBarItemUserCollectionView.Name = "tileBarItemUserCollectionView";
            // 
            // tileBarGroupViews
            // 
            this.tileBarGroupViews.Name = "tileBarGroupViews";
            this.tileBarGroupViews.Text = "VIEWS";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 110);
            this.navigationFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.SelectedPage = null;
            this.navigationFrame.Size = new System.Drawing.Size(1024, 658);
            this.navigationFrame.TabIndex = 0;
            this.navigationFrame.Text = "navigationFrame";
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(RentCar.App.ViewModels.RentCarDbContextViewModel);
            // 
            // RentCarDbContextView
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.tileBar);
            this.Name = "RentCarDbContextView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

		}
		
        #endregion

		private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupViews;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemClientPreferredContactMediumCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemClientCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemEmployeeCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemFuelTypeCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemVehicleCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemVehicleBrandCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemVehicleModelCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemVehicleTypeCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemInspectionCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemRentCollectionView;
				private DevExpress.XtraBars.Navigation.TileBarItem tileBarItemUserCollectionView;
					}
}

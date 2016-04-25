using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArcGIS.Desktop.Core;
using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Framework.Contracts;

namespace SchemaReader
{
    internal class DockpaneViewModel : DockPane
    {
        private const string _dockPaneID = "SchemaReader_Dockpane";

        protected override Task InitializeAsync()
        {
            INotifyCollectionChanged selectedProjectItems = Project.Current.SelectedItems;
            selectedProjectItems.CollectionChanged += OnSelectedProjectItemsCollectionChanged;
            return base.InitializeAsync();
        }

        private void OnSelectedProjectItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs)
        {
            var selectedProjectItems = Project.Current.SelectedItems;
            if (selectedProjectItems.Count != 1) return;
            var selectedItem = selectedProjectItems[0];
            Item ted;
        }

        /// <summary>
        /// Show the DockPane.
        /// </summary>
        internal static void Show()
        {
            var pane = FrameworkApplication.DockPaneManager.Find(_dockPaneID);           
            pane?.Activate();
        }

        /// <summary>
        /// Text shown near the top of the DockPane.
        /// </summary>
        private string _heading = "Schema Reader";
        public string Heading
        {
            get { return _heading; }
            set
            {
                SetProperty(ref _heading, value, () => Heading);
            }
        }
    }

    ///// <summary>
    ///// Button implementation to show the DockPane.
    ///// </summary>
    //internal class Dockpane_ShowButton : Button
    //{
    //    protected override void OnClick()
    //    {
    //        DockpaneViewModel.Show();
    //    }
    //}
}

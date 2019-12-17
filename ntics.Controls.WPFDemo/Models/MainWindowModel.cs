using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ntics.Controls.WPFDemo.Models
{
    public class MainWindowModel
    {
        public BindingList<DemoModel> ComboBoxItems { get; set; } = new BindingList<DemoModel>();
        
        public DemoModel SelectedItem { get; set; }
        
        public string SelectedFoleder { get; set; }
        public MainWindowModel()
        {
            ComboBoxItems = new BindingList<DemoModel>
            {
                new DemoModel{Value= "Test 1" },
                new DemoModel{Value= "Test 2" },
                new DemoModel{Value= "Test 3" },
                new DemoModel{Value= "Test 4" }

            };
            SelectedItem = ComboBoxItems[0];
        }

        public static MainWindowModel TestModel { get; set; } = new MainWindowModel();



    }
}

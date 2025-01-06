
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizeLegendLayout
{
    internal class ViewModel
    {
        public ObservableCollection<Model> Data {  get; set; }
        public ObservableCollection<Brush> CustomBrushes { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>()
            {
                new Model { Stage = "Total Audience Reached", Value = 150000 },
                new Model { Stage = "Website Visitors", Value = 140000 },
                new Model { Stage = "Landing Page Views", Value = 130000 },
                new Model { Stage = "Clicked on Advertisement", Value = 120000 },
                new Model { Stage = "Engaged with Content", Value = 115000 },
                new Model { Stage = "Viewed Product Information", Value = 110000 },
                new Model { Stage = "Added to Wishlist", Value = 105000 },
                new Model { Stage = "Added to Cart", Value = 100000 },
                new Model { Stage = "Initiated Checkout", Value = 95000 },
                new Model { Stage = "Payment Information Entered", Value = 90000 },
                new Model { Stage = "Completed Transaction", Value = 85000 },
                new Model { Stage = "Post-Purchase Engagement", Value = 80000 },
                new Model { Stage = "Received Shipping Confirmation", Value = 75000 },
                new Model { Stage = "First-Time Buyer Confirmation", Value = 70000 },
                new Model { Stage = "Repeat Visits", Value = 65000 },
                new Model { Stage = "Customer Reviews Submitted", Value = 60000 }
            };

            CustomBrushes = new ObservableCollection<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#FF6F61")),  
                new SolidColorBrush(Color.FromArgb("#6B5B95")),  
                new SolidColorBrush(Color.FromArgb("#88B04B")),  
                new SolidColorBrush(Color.FromArgb("#F4A300")),  
                new SolidColorBrush(Color.FromArgb("#F1C40F")),  
                new SolidColorBrush(Color.FromArgb("#1F77B4")),  
                new SolidColorBrush(Color.FromArgb("#D9BF77")),  
                new SolidColorBrush(Color.FromArgb("#E74C3C")),  
                new SolidColorBrush(Color.FromArgb("#27AE60")),  
                new SolidColorBrush(Color.FromArgb("#2980B9")),  
                new SolidColorBrush(Color.FromArgb("#8E44AD")),  
                new SolidColorBrush(Color.FromArgb("#16A085")),  
                new SolidColorBrush(Color.FromArgb("#E67E22")), 
                new SolidColorBrush(Color.FromArgb("#D3A6D3")),  
                new SolidColorBrush(Color.FromArgb("#34495E")),  
                new SolidColorBrush(Color.FromArgb("#16A085"))  
            };
        }
    }
}

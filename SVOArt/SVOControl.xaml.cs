using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SVOArt.Models;

namespace SVOArt
{
    public partial class SVOControl : UserControl
    {
        public Sentence Sentence
        {
            get => (Sentence)GetValue(SentenceProperty);
            set => SetValue(SentenceProperty, value);
        }

        public static readonly DependencyProperty SentenceProperty =
            DependencyProperty.Register("Sentence", typeof(Sentence),
                typeof(SVOControl), new PropertyMetadata());

        public SVOControl()
        {
            InitializeComponent();
        }
    }
}

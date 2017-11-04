using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Xml;

namespace HitTest.Controls
{
    /// <summary>
    ///Control to test which of the children recived the button pressed event.
    /// </summary>
    public class HitTestControl : ContentControl
    {
        /// <summary>
        /// List that store the objects/controls that were under the mouse when clicked.
        /// and there <code>IsHitTestVisible == true</code>.
        /// </summary>
        private List<DependencyObject> hitResults;

        static HitTestControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(HitTestControl), new FrameworkPropertyMetadata(typeof(HitTestControl)));
        }

        protected override void OnPreviewMouseDown(MouseButtonEventArgs e)
        {
            base.OnPreviewMouseDown(e);

            // Retrieve the coordinate of the mouse position.
            ShowNotifiedChildren(e.GetPosition(this));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            hitResults = new List<DependencyObject>();
        }

        // Return the result of the hit test to the callback.
        public HitTestResultBehavior MyHitTestResult(HitTestResult result)
        {
            hitResults.Add(result.VisualHit);
            return HitTestResultBehavior.Continue;
        }

        private void ShowNotifiedChildren(Point point)
        {
            hitResults.Clear();

            VisualTreeHelper.HitTest(this, null,
                new HitTestResultCallback(MyHitTestResult),
                new PointHitTestParameters(point));

            // Display a new window with a list of all the controls that "got hit".
            DisplayUiElements(hitResults);
        }

        private void DisplayUiElements(List<DependencyObject> elements)
        {
            if (elements.Count > 0)
            {
                Window newWindow = new Window();

                newWindow.MaxHeight = 500;
                newWindow.MaxWidth = 500;

                ListView listView = new ListView();

                foreach (var item in elements)
                {
                    if (item is UIElement)
                    {
                        listView.Items.Add(CloneXaml((UIElement)item));
                    }

                }
                newWindow.Content = listView;
                newWindow.Show();
            }
        }

        /// <summary>
        /// Clone UiElements
        /// </summary>
        /// <param name="element">The element to be cloned.</param>
        /// <returns></returns>
        public static UIElement CloneXaml(UIElement element)
        {
            string xaml = XamlWriter.Save(element);
            UIElement clone;

            using (StringReader stringReader = new StringReader(xaml))
            {
                using (XmlReader xmlReader = XmlReader.Create(stringReader))
                {
                    clone = XamlReader.Load(xmlReader) as UIElement;
                }
            }

            return clone;
        }
    }
}

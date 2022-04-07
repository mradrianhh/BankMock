using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMock.Console.Core
{
    public class ViewCollection : IEnumerable<View>
    {
        public IDictionary<string, View> Views;

        public ViewCollection()
        {
            Views = new Dictionary<string, View>();
        }

        public void AddView(ViewModel viewModel, View view)
        {
            view.ViewModel = viewModel;
            viewModel.View = view;

            Views.Add(view.Identifier, view);
        }

        public IEnumerator<View> GetEnumerator()
        {
            foreach(var view in Views.Values)
            {
                yield return view;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

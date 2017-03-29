using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayX.ExtensionMarkup
{
    //Aula 30
    [Xamarin.Forms.ContentProperty("ResourceId")] //Plus no código definindo propriedade padrão
    public class EmbeddedImage : Xamarin.Forms.Xaml.IMarkupExtension
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ResourceId))
                return null;

            return Xamarin.Forms.ImageSource.FromResource(ResourceId);
        }

        public string ResourceId { get; set; }
    }
}

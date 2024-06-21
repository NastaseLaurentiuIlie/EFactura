    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFactura.Files
{
    public class FileGeneratorFactory
    {
        public enum GeneratorType
        {
            PDFGenerator,
            XMLGenerator
        }
        private readonly IServiceProvider _serviceProvider;


        public FileGeneratorFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IFileGenerator GetFileGenerator(GeneratorType generatorType)
        {
            if (generatorType.Equals(GeneratorType.PDFGenerator))
                return (IFileGenerator)_serviceProvider.GetService(typeof(PDFGenerator));

            return (IFileGenerator)_serviceProvider.GetService(typeof(XmlGenerator));
        }
    }
}

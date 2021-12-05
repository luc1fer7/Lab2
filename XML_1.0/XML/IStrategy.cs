using System.Collections.Generic;

namespace XML
{
    interface IStrategy
    {
        List<Xml_Reader> FindInFile(Xml_Reader _reader, string path);
    }
}

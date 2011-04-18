using System.IO;

namespace StitchIt
{
    public class ResourceReader
    {
        const string DefaultNamespace = "StitchIt.Resources";

        public string Read(string name, string @namespace = DefaultNamespace)
        {
            var assembly = typeof(ResourceReader).Assembly;
            var fullName = string.Format("{0}.{1}", @namespace, name);

            using (var stream = assembly.GetManifestResourceStream(fullName))
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k8s;
using k8s.Models;
using YamlDotNet.Serialization;

namespace k8s_manifest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                // Create Namespace object
                var ns = new V1Namespace
                {
                    Metadata = new V1ObjectMeta
                    {
                        Name = "example-namespace",
                    }
                };

                // Serialize Namespace object to YAML
                var serializer = new SerializerBuilder().Build();
                var yaml = serializer.Serialize(ns);

                // Print YAML
                //Console.WriteLine("Namespace manifest:");
                Console.WriteLine(yaml);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

using Aurigma.Design;
using Aurigma.Design.Appearance;
using Aurigma.Design.Appearance.Color;
using Aurigma.Design.Content;
using Aurigma.Design.Content.Controls;
using Aurigma.Design.Math;
using Google.Protobuf;
using ApiClient;

namespace DesignUsageExample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            IDesignsApiClient client = new DesignsApiClient(
                "https://localhost:7091/", 
                new HttpClient());

            try
            {
                Console.WriteLine("Recieving designs...");

                var designs = await client.ListDesignsAsync();

                Console.WriteLine("All designs:");
                foreach (var d in designs)
                {
                    Console.WriteLine(d.Name);
                }

                Console.Write("\nName: ");
                string name = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("Deleting...");

                await client.DeleteDesignAsync(name);

                Console.WriteLine("Done");

                //Console.WriteLine("\nRecieving data...");

                //var designContent = await client.GetDesignContentAsync(name);
                //Design design = Design.Parser.ParseFrom(designContent.Stream);

                //Console.WriteLine($"\nContent:\n{design.ToString()}");

                //Color green = new Color()
                //{
                //    Process = new ProcessColor()
                //    {
                //        Alpha = 255,
                //        Rgb = new RgbColor()
                //        {
                //            R = 0,
                //            G = 255,
                //            B = 0
                //        }
                //    }
                //};
                //Color blue = new Color()
                //{
                //    Process = new ProcessColor()
                //    {
                //        Alpha = 255,
                //        Rgb = new RgbColor()
                //        {
                //            R = 0,
                //            G = 0,
                //            B = 255
                //        }
                //    }
                //};
                //Brush greenBrush = new Brush()
                //{
                //    Solid = new SolidBrush()
                //    {
                //        Color = green
                //    }
                //};
                //Brush blueBrush = new Brush()
                //{
                //    Solid = new SolidBrush()
                //    {
                //        Color = blue
                //    }
                //};
                //IEnumerable<Element> elements = new List<Element>()
                //{
                //    new Element()
                //    {
                //        Position = new Point(100, 100),
                //        ReferencePoint = ReferencePointType.TopLeftCorner,
                //        Transform = Affine2DMatrix.CreateIdentity(),
                //        Content = new ElementContent()
                //        {
                //            ClosedVector = new ClosedVector()
                //            {
                //                Fill = blueBrush,
                //                Controls = new ClosedVectorControls()
                //                {
                //                    Rectangle = new RectangleControls()
                //                    {
                //                        Corner1 = new Point(0, 0),
                //                        Corner2 = new Point(50, 50)
                //                    }
                //                }
                //            }
                //        } 
                //    },
                //    new Element()
                //    {
                //        Position = new Point(0, 0),
                //        ReferencePoint = ReferencePointType.TopLeftCorner,
                //        Transform = Affine2DMatrix.CreateIdentity(),
                //        Content = new ElementContent()
                //        {
                //            ClosedVector = new ClosedVector()
                //            {
                //                Fill = greenBrush,
                //                Controls = new ClosedVectorControls()
                //                {
                //                    Rectangle = new RectangleControls()
                //                    {
                //                        Corner1 = new Point(0, 0),
                //                        Corner2 = new Point(50, 70)
                //                    }
                //                }
                //            }
                //        }
                //    }
                //};
                //Design design = Design.CreateBlank();
                //design.Surfaces.First().Layers.First().Elements.AddRange(elements);

                //Stream data = new MemoryStream();
                //design.WriteTo(data);
                //data.Position = 0;
                //FileParameter file = new FileParameter(data);
                //Console.WriteLine("\nUploading...\n");
                //DesignDto dto = await client.UploadDesignAsync(file);
                //Console.WriteLine(dto.Name);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
        }
    }
}

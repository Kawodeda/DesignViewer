namespace BlazorViewer.Server.Dtos
{
    public class FileErrorDto
    {
        public string Name { get; set; }

        public override bool Equals(object? other)
        {
            return other is FileErrorDto dto 
                && Name.Equals(dto.Name);
        }
    }
}

namespace BlazorViewer.Server.Dtos
{
    public class DesignDto
    {
        public string Name { get; set; }

        public override bool Equals(object? other)
        {
            return other is DesignDto dto 
                && Name.Equals(dto.Name);
        }
    }
}

namespace DesignViewer.Server.Dtos
{
    public class DesignDto
    {
        public string Name { get; set; } = string.Empty;

        public override bool Equals(object? other)
        {
            return other is DesignDto dto 
                && Name.Equals(dto.Name);
        }
    }
}

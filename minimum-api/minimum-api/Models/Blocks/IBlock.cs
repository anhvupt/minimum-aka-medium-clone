namespace minimum_api.Models.Blocks
{
    public interface IBlock
    {
        string Type { get; }
        string Data { get; set; }
        int Order { get; set; }
    }
}

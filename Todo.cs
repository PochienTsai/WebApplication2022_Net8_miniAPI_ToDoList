public class Todo
{
    public int Id { get; set; }    // 自動產生流水號（P.K. 主索引鍵）
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
    public string? Secret { get; set; }
}

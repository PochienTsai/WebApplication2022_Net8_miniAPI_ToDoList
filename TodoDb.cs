using Microsoft.EntityFrameworkCore;

class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }
    // InMemory資料庫，不需要使用連線字串（專案不執行就自動清空了。無法保留資料）

    public DbSet<Todo> Todos => Set<Todo>();
}

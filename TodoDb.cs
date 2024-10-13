using Microsoft.EntityFrameworkCore;

class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }
    // InMemory��Ʈw�A���ݭn�ϥγs�u�r��]�M�פ�����N�۰ʲM�ŤF�C�L�k�O�d��ơ^

    public DbSet<Todo> Todos => Set<Todo>();
}

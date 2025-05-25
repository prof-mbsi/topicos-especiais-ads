using aula2305.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

List<Livro> livros = new List<Livro>
{
    new Livro(1, "Primeiro Livro", 1990),
    new Livro(2, "Segundo Livro", 1875)
};

List<Tarefa> tarefas = new List<Tarefa>
{
    new Tarefa(1, "Trabalho de Tópicos Especiais", false),
    new Tarefa(2, "Trabalho de Java", true)
};

//ListAll:
    app.MapGet("/livros", () => {
        return Results.Ok(livros);
    });

    app.MapGet("/tarefas", () => {
        return Results.Ok(tarefas);
    });

//GetByID: 
    app.MapGet("/livros/{id}", (int id) => {
        var livro = livros.FirstOrDefault(p => p.Id == id);
        return livro != null ? Results.Ok(livro) : Results.NotFound();
    });

    app.MapGet("/tarefas/{id}", (int id) => {
        var tarefa = tarefas.FirstOrDefault(p => p.Id == id);
        return tarefa != null ? Results.Ok(tarefa) : Results.NotFound();
    });

//Add:
    app.MapPost("/livros", (Livro livro) => {
        if (livros.Any(l => l.Id == livro.Id)) {
            return Results.BadRequest("Livro com mesmo ID já existe.");
        }
        livros.Add(livro);
        return Results.Created($"/livros/{livro.Id}", livro);
    });

    app.MapPost("/tarefas", (Tarefa tarefa) => {
        if (tarefas.Any(t => t.Id == tarefa.Id)) {
            return Results.BadRequest("Tarefa com mesmo ID já existe.");
        }
        tarefas.Add(tarefa);
        return Results.Created($"/tarefas/{tarefa.Id}", tarefa);
    });

//Update:
    app.MapPut("/livros/{id}", (int id, Livro livroAtualizado) => {
        var livro = livros.FirstOrDefault(l => l.Id == id);
        if (livro == null)
            return Results.NotFound();
        livro.Titulo = livroAtualizado.Titulo;
        livro.Ano = livroAtualizado.Ano;
        return Results.Ok(livro);
    });
    app.MapPut("/tarefas/{id}", (int id, Tarefa tarefaAtualizada) => {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa == null)
            return Results.NotFound();
        tarefa.Descricao = tarefaAtualizada.Descricao;
        tarefa.Concluida = tarefaAtualizada.Concluida;
        return Results.Ok(tarefa);
    });

//Delete:
    app.MapDelete("/livros/{id}", (int id) => {
        var livro = livros.FirstOrDefault(l => l.Id == id);
        if (livro == null)
            return Results.NotFound();
        livros.Remove(livro);
        return Results.Ok($"Livro {id} removido com sucesso.");
    });
    app.MapDelete("/tarefas/{id}", (int id) => {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if (tarefa == null)
            return Results.NotFound();
        tarefas.Remove(tarefa);
        return Results.Ok($"Tarefa {id} removida com sucesso.");
    });

app.Run();
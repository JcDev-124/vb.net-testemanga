@Code
    ViewData("Title") = "Cadastro de Apoio a uma Causa"
End Code

<div class="jumbotron">
    <h1>Cadastre-se e Apoie uma Causa!</h1>
    <p class="lead">Junte-se a nós para fazer a diferença. Cada cadastro é um passo para um mundo melhor.</p>
    <p><a href="#" class="btn btn-primary btn-lg">Saiba mais &raquo;</a></p>
</div>

<div class="row">
    <div class="col-md-6">
        <div class="card">
            <div class="card-body">
                <h2 class="card-title">Faça Parte</h2>
                <p class="card-text">Clique no botão abaixo para se cadastrar e fazer parte desta causa.</p>
                <p><a class="btn btn-primary" href="@Url.Action("Register", "Account")">Cadastrar &raquo;</a></p>
            </div>
        </div>
    </div>
    <div class="col-md-6">
        <div class="card">
            <div class="card-body">
                <h2 class="card-title">Veja Quem Já Está Apoiando</h2>
                <p class="card-text">Veja todos os usuários que já estão cadastrados e apoiando esta causa.</p>
                <p><a class="btn btn-secondary" href="@Url.Action("GetAllUsers", "Account")">Ver Usuários &raquo;</a></p>
            </div>
        </div>
    </div>
</div>
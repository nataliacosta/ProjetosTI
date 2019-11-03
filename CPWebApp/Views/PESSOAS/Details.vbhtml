@ModelType CPWebApp.CPWebApp.PESSOAS

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Details</title>
</head>
<body>
    <div>
        <h4>PESSOAS</h4>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                @Html.DisplayNameFor(Function(model) model.nome)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.nome)
            </dd>
    
            <dt>
                @Html.DisplayNameFor(Function(model) model.PESSOAS2.nome)
            </dt>
    
            <dd>
                @Html.DisplayFor(Function(model) model.PESSOAS2.nome)
            </dd>
    
        </dl>
    </div>
    <p>
        @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
        @Html.ActionLink("Back to List", "Index")
    </p>
</body>
</html>

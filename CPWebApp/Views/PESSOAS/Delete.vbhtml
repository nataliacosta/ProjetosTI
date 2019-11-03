@ModelType CPWebApp.CPWebApp.PESSOAS

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Delete</title>
</head>
<body>
    <h3>Are you sure you want to delete this?</h3>
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
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()
    
            @<div class="form-actions no-color">
                <input type="submit" value="Delete" class="btn btn-default" /> |
                @Html.ActionLink("Back to List", "Index")
            </div>
        End Using
    </div>
</body>
</html>

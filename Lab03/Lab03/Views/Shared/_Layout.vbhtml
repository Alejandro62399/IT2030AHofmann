﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
	<div class="header">
		<center>
			<h1>Welcome to XYZ Store</h1>
		</center>
	</div>
	<div class="navbar navbar-inverse navbar-fixed-top">
		<div class="container">
			<div class="navbar-header">
				<button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
					<span class="icon-bar"></span>
				</button>
				@Html.ActionLink("Application name", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
			</div>
			<div class="navbar-collapse collapse">
				<ul class="nav navbar-nav">
					<li>@Html.ActionLink("Home", "Index", "Home")</li>
					<li>@Html.ActionLink("About", "About", "Home")</li>
					<li>@Html.ActionLink("Contact", "Contact", "Home")</li>
				</ul>
			</div>
		</div>
	</div>
	<div class="container body-content">
		@RenderBody()
		<hr />
		<footer>
			<center>
				<h1>
					Copyright of XYZ Store
				</h1>
			</center>
		</footer>
	</div>

	@Scripts.Render("~/bundles/jquery")
	@Scripts.Render("~/bundles/bootstrap")
	@RenderSection("scripts", required:=False)
</body>
</html>

runserver-watch:
	dotnet watch

compilestyles-watch:
	npx tailwindcss -i ./Styles/app.css -o ./wwwroot/static/app.css --watch

startmigration:
	dotnet ef migrations add $(ARGS)

migrate:
	dotnet ef database update
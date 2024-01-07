runserver-watch:
	dotnet watch

compilestyles-watch:
	npx tailwindcss -i ./Styles/app.css -o ./wwwroot/static/app.css --watch

makemigrations:
	dotnet ef migrations add $(name)

migrate:
	dotnet ef database update
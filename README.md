# Cyberdruzhina

Черновой монорепозиторий для демонстрации структуры проекта.

## Запуск

```bash
docker compose -f docker/docker-compose.yml up --build
```

API будет доступно на `http://localhost:5000/swagger`.

## Структура

- `src/Backend` — проекты ASP.NET Core (Domain, Application, Infrastructure, Api, Telegram).
- `src/Frontend/kiber-admin` — Angular SPA.
- `tests` — xUnit тесты.
- `docker` — docker-compose и образы.
- `.github/workflows` — CI конфигурация.

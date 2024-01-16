# Study - Dotnet Rabbitmq

The focus of this project is...

# Projects

## Source

- Presentation Web API

- Application

- Domain

- Infrastructure

## Tests

- Presentation Web API (tests)

- Application (tests)

- Domain (tests)

- Infrastructure (tests)

# How to run

## Local

First, we should execute this command below.

```bash

dotnet run --project ./src/Presentation.WebApi/Presentation.WebApi.csproj

```

Then, open this link http://localhost:5119/swagger/index.html.

## Docker Compose

```bash

docker compose down && docker compose up

```

### RabbitMQ

So, we can open this link http://localhost:15672/ and access the admin using the credential below.

- Username: `rabbitmq-user`
- Password: `Nd9zY3Q8syCLZe24u#Mt@J`
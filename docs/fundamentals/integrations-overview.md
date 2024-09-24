---
title: .NET Aspire integrations overview
description: Explore the fundamental concepts of .NET Aspire integrations and learn how to integrate them into your apps.
ms.date: 09/23/2024
ms.topic: conceptual
---

# .NET Aspire integrations overview

.NET Aspire integrations are a curated suite of NuGet packages selected to facilitate the integration of cloud-native applications with prominent services and platforms, such as Redis and PostgreSQL. Each integration furnishes essential cloud-native functionalities through either automatic provisioning or standardized configuration patterns.

> [!TIP]
> Always strive to use the latest version of .NET Aspire integrations to take advantage of the latest features, improvements, and security updates.

## Integration responsibilities

Most .NET Aspire integrations are made up of 2 separate libraries, each with a different responsibility. One type represents resources within the app host project—these are known as [hosting integrations](#hosting-integrations). The other type of integration represents client libraries that connect to the aforementioned resources, and they're known as [client integrations](#client-integrations).

### Hosting integrations

Hosting integrations configure applications by provisioning resources (like containers or cloud resources) or pointing to existing instances (such as a local SQL server). These packages model various services, platforms, or capabilities, including caches, databases, logging, storage, and messaging systems.

Hosting integrations extend the <xref:Aspire.Hosting.IDistributedApplicationBuilder> interface, enabling the _app host_ project to express resources within its _app model_. The official [hosting integration NuGet packages](https://www.nuget.org/packages?q=owner%3A+aspire+tags%3A+aspire+hosting+integration&includeComputedFrameworks=true&prerel=true&sortby=relevance) are tagged with `aspire`, `integration`, and `hosting`.

For information on creating a custom hosting integration, see [Create custom .NET Aspire hosting integration](../extensibility/custom-hosting-integration.md).

### Client integrations

Client integrations wire up client libraries to dependency injection (DI), define configuration schema, and add health checks, resiliency, and telemetry where applicable. These packages configure existing client libraries to connect to hosting integrations. They extend the <xref:Microsoft.Extensions.Hosting.IHostApplicationBuilder> interface allowing client-consuming projects, such as your web app or API, to use the connected resource. The official [client integration NuGet packages](https://www.nuget.org/packages?q=owner%3A+aspire+tags%3A+aspire+client+integration&includeComputedFrameworks=true&prerel=true&sortby=relevance) are tagged with `aspire`, `integration`, and `client`.

For more information on creating a custom client integration, see [Create custom .NET Aspire client integrations](../extensibility/custom-client-integration.md).

### Relationship between hosting and client integrations

Hosting and client integrations are best when used together, but are **not** coupled and may be used separately. Some hosting integrations may not have a corresponding client integration. Configuration is what makes the hosting integration work with the client integration.

Consider the following diagram that depicts the relationship between hosting and client integrations:

:::image type="content" source="media/integrations-thumb.png" lightbox="media/integrations.png" alt-text="A diagram ":::

The app host project is where hosting integrations are used. Configuration, specifically environment variables, is injected into projects, executables, and containers, allowing client integrations to connect to the hosting integrations.

## Available integrations

The following section details the available .NET Aspire integrations, links to their respective NuGet packages, and provides a brief description of each integration.

<!-- markdownlint-disable MD033 MD045 -->
| Integration | Docs and NuGet packages | Description |
|--|--|--|
| <img src="media/icons/Aspire-logo-256.png" alt=".NET Aspire logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Apache Kafka](../messaging/kafka-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Kafka](https://www.nuget.org/packages/Aspire.Hosting.Kafka)<br>- **Client**: [📦 Aspire.Confluent.Kafka](https://www.nuget.org/packages/Aspire.Confluent.Kafka) | A library for producing and consuming messages from an [Apache Kafka](https://kafka.apache.org/) broker. |
| <img src="media/icons/Aspire-logo-256.png" alt=".NET Aspire logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Dapr](../frameworks/dapr.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Dapr](https://www.nuget.org/packages/Aspire.Hosting.Dapr)<br>- **Client**: N/A | A library for modeling [Dapr](https://dapr.io/) as a .NET Aspire resource. |
| <img src="media/icons/Elastic_logo_256x.png" alt="Elasticsearch logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Elasticsearch](../search/elasticsearch-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Elasticsearch](https://www.nuget.org/packages/Aspire.Hosting.Elasticsearch)<br>- **Client**: [📦 Aspire.Elastic.Clients.Elasticsearch](https://www.nuget.org/packages/Aspire.Elastic.Clients.Elasticsearch) | A library for accessing [Elasticsearch](https://www.elastic.co/guide/en/elasticsearch/client/index.html) databases. |
| <img src="media/icons/Aspire-logo-256.png" alt=".NET Aspire logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Keycloak](../authentication/keycloak-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Keycloak](https://www.nuget.org/packages/Aspire.Hosting.Keycloak)<br>- **Client**: [📦 Aspire.Keycloak.Authentication](https://www.nuget.org/packages/Aspire.Keycloak.Authentication) | A library for accessing [Keycloak](https://www.keycloak.org/docs/latest/server_admin/index.html) authentication. |
| <img src="media/icons/Milvus_256x.png" alt="Milvus logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Milvus](../database/milvus-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Milvus](https://www.nuget.org/packages/Aspire.Hosting.Milvus)<br>- **Client**: [📦 Aspire.Milvus.Client](https://www.nuget.org/packages/Aspire.Milvus.Client) | A library for accessing [Milvus](https://milvus.io/) databases. |
| <img src="media/icons/MongoDB_256px.png" alt="MongoDB logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 MongoDB Driver](../database/mongodb-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.MongoDB](https://www.nuget.org/packages/Aspire.Hosting.MongoDB)<br>- **Client**: [📦 Aspire.MongoDB.Driver](https://www.nuget.org/packages/Aspire.MongoDB.Driver) | A library for accessing [MongoDB](https://www.mongodb.com/docs) databases. |
| <img src="media/icons/mysqlconnector_logo.png" alt="MySqlConnector logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 MySqlConnector](../database/mysql-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.MySql](https://www.nuget.org/packages/Aspire.Hosting.MySql)<br>- **Client**: [📦 Aspire.MySqlConnector](https://www.nuget.org/packages/Aspire.MySqlConnector) | A library for accessing [MySqlConnector](https://mysqlconnector.net/) databases. |
| <img src="media/icons/nats-icon.png" alt="NATS logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 NATS](../messaging/nats-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Nats](https://www.nuget.org/packages/Aspire.Hosting.Nats)<br>- **Client**: [📦 Aspire.NATS.Net](https://www.nuget.org/packages/Aspire.NATS.Net) | A library for accessing [NATS](https://nats.io/) messaging. |
| <img src="media/icons/Aspire-logo-256.png" alt=".NET Aspire logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Oracle - EF Core](../database/oracle-entity-framework-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Oracle](https://www.nuget.org/packages/Aspire.Hosting.Oracle)<br>- **Client**: [📦 Aspire.Oracle.EntityFrameworkCore](https://www.nuget.org/packages/Aspire.Oracle.EntityFrameworkCore) | A library for accessing Oracle databases with [Entity Framework Core](/ef/core). |
| <img src="/dotnet/media/dotnet-Orleans.png" alt="Microsoft Orleans logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Orleans](../frameworks/Orleans.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Orleans](https://www.nuget.org/packages/Aspire.Hosting.Orleans)<br>- **Client**: N/A | A library for modeling [Orleans](/dotnet/Orleans) as a .NET Aspire resource. |
| <img src="media/icons/Aspire-logo-256.png" alt=".NET Aspire logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Pomelo MySQL - EF Core](../database/mysql-entity-framework-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.MySql](https://www.nuget.org/packages/Aspire.Hosting.MySql)<br>- **Client**: [📦 Aspire.Pomelo.EntityFrameworkCore.MySql](https://www.nuget.org/packages/Aspire.Pomelo.EntityFrameworkCore.MySql) | A library for accessing MySql databases with [Entity Framework Core](/ef/core). |
| <img src="media/icons/PostgreSQL_logo.3colors.256x.png" alt="PostgreSQL logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 PostgreSQL - EF Core](../database/postgresql-entity-framework-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.PostgreSQL](https://www.nuget.org/packages/Aspire.Hosting.PostgreSQL)<br>- **Client**: [📦 Aspire.Npgsql.EntityFrameworkCore.PostgreSQL](https://www.nuget.org/packages/Aspire.Npgsql.EntityFrameworkCore.PostgreSQL) | A library for accessing PostgreSQL databases using [Entity Framework Core](https://www.npgsql.org/efcore/index.html). |
| <img src="media/icons/PostgreSQL_logo.3colors.256x.png" alt="PostgreSQL logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 PostgreSQL](../database/postgresql-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.PostgreSQL](https://www.nuget.org/packages/Aspire.Hosting.PostgreSQL)<br>- **Client**: [📦 Aspire.Npgsql](https://www.nuget.org/packages/Aspire.Npgsql) | A library for accessing [PostgreSQL](https://www.npgsql.org/doc/index.html) databases. |
| <img src="media/icons/QdrantLogo_256x.png" alt="Qdrant logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Qdrant](../database/qdrant-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Qdrant](https://www.nuget.org/packages/Aspire.Hosting.Qdrant)<br>- **Client**: [📦 Aspire.Qdrant.Client](https://www.nuget.org/packages/Aspire.Qdrant.Client) | A library for accessing [Qdrant](https://qdrant.tech/) databases. |
| <img src="media/icons/Aspire-logo-256.png" alt=".NET Aspire logo." role="presentation" width="78" data-linktype="relative-path"> |  - **Learn more**: [📄 RabbitMQ](../messaging/rabbitmq-client-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.RabbitMQ](https://www.nuget.org/packages/Aspire.Hosting.RabbitMQ)<br>- **Client**: [📦 Aspire.RabbitMQ.Client](https://www.nuget.org/packages/Aspire.RabbitMQ.Client) | A library for accessing [RabbitMQ](https://www.rabbitmq.com/dotnet.html). |
| <img src="media/icons/redis-cube-red_white-rgb.png" alt="Redis logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Redis Distributed Caching](../caching/stackexchange-redis-distributed-caching-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Redis](https://www.nuget.org/packages/Aspire.Hosting.Redis), [📦 Aspire.Hosting.Garnet](https://www.nuget.org/packages/Aspire.Hosting.Garnet), or [📦 Aspire.Hosting.Valkey](https://www.nuget.org/packages/Aspire.Hosting.Valkey)<br>- **Client**: [📦 Aspire.StackExchange.Redis.DistributedCaching](https://www.nuget.org/packages/Aspire.StackExchange.Redis.DistributedCaching) | A library for accessing [Redis](https://stackexchange.github.io/StackExchange.Redis/) caches for [distributed caching](/aspnet/core/performance/caching/distributed). |
| <img src="media/icons/redis-cube-red_white-rgb.png" alt="Redis logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Redis Output Caching](../caching/stackexchange-redis-output-caching-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Redis](https://www.nuget.org/packages/Aspire.Hosting.Redis), [📦 Aspire.Hosting.Garnet](https://www.nuget.org/packages/Aspire.Hosting.Garnet), or [📦 Aspire.Hosting.Valkey](https://www.nuget.org/packages/Aspire.Hosting.Valkey)<br>- **Client**: [📦 Aspire.StackExchange.Redis.OutputCaching](https://www.nuget.org/packages/Aspire.StackExchange.Redis.OutputCaching) | A library for accessing [Redis](https://stackexchange.github.io/StackExchange.Redis/) caches for [output caching](/aspnet/core/performance/caching/output). |
| <img src="media/icons/redis-cube-red_white-rgb.png" alt="Redis logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Redis](../caching/stackexchange-redis-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Redis](https://www.nuget.org/packages/Aspire.Hosting.Redis), [📦 Aspire.Hosting.Garnet](https://www.nuget.org/packages/Aspire.Hosting.Garnet), or [📦 Aspire.Hosting.Valkey](https://www.nuget.org/packages/Aspire.Hosting.Valkey)<br>- **Client**: [📦 Aspire.StackExchange.Redis](https://www.nuget.org/packages/Aspire.StackExchange.Redis) | A library for accessing [Redis](https://stackexchange.github.io/StackExchange.Redis/) caches. |
| <img src="media/icons/Seq_logo.256x.png" alt="Seq logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Seq](../logging/seq-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Seq](https://www.nuget.org/packages/Aspire.Hosting.Seq)<br>- **Client**: [📦 Aspire.Seq](https://www.nuget.org/packages/Aspire.Seq) | A library for logging to [Seq](https://datalust.co/seq). |
| <img src="media/icons/SQL_256x.png" alt="SQL logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 SQL Server - EF Core](../database/sql-server-entity-framework-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.SqlServer](https://www.nuget.org/packages/Aspire.Hosting.SqlServer)<br>- **Client**: [📦 Aspire.Microsoft.EntityFrameworkCore.SqlServer](https://www.nuget.org/packages/Aspire.Microsoft.EntityFrameworkCore.SqlServer) | A library for accessing [SQL Server databases using EF Core](/ef/core/providers/sql-server/). |
| <img src="media/icons/SQL_256x.png" alt="SQL logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 SQL Server](../database/sql-server-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.SqlServer](https://www.nuget.org/packages/Aspire.Hosting.SqlServer)<br>- **Client**: [📦 Aspire.Microsoft.Data.SqlClient](https://www.nuget.org/packages/Aspire.Microsoft.Data.SqlClient) | A library for accessing [SQL Server](/sql/sql-server/) databases. |
<!-- markdownlint-enable MD033 MD045 -->

For more information on working with .NET Aspire integrations in Visual Studio, see [Visual Studio tooling](setup-tooling.md#visual-studio-tooling).

### Azure integrations

Azure integrations configure applications to use Azure resources. These hosting integrations are available in the `Aspire.Hosting.Azure.*` NuGet packages, while their client integrations are available in the `Aspire.*` NuGet packages.:

<!-- markdownlint-disable MD033 MD045 -->
| Integration | Docs and NuGet packages | Description |
|--|--|--|
| <img src="media/icons/AzureAppConfig_256x.png" alt="Azure App Configuration logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure App Configuration](https://github.com/dotnet/aspire/blob/main/src/Aspire.Hosting.Azure.AppConfiguration/README.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.AppConfiguration](https://www.nuget.org/packages/Aspire.Hosting.Azure.AppConfiguration)<br>- **Client**: N/A | A library for interacting with [Azure App Configuration](/azure/azure-app-configuration/). |
| <img src="media/icons/AzureAppInsights_256x.png" alt="Azure Application Insights logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure Application Insights](https://github.com/dotnet/aspire/blob/main/src/Aspire.Hosting.Azure.ApplicationInsights/README.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.ApplicationInsights](https://www.nuget.org/packages/Aspire.Hosting.Azure.ApplicationInsights)<br>- **Client**: N/A | A library for interacting with [Azure Application Insights](/azure/azure-monitor/app/app-insights-overview). |
| <img src="media/icons/AzureCosmosDB_256x.png" alt="Azure Cosmos DB EF logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure Cosmos DB - EF Core](../database/azure-cosmos-db-entity-framework-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.CosmosDB](https://www.nuget.org/packages/Aspire.Hosting.Azure.CosmosDB)<br>- **Client**: [📦 Aspire.Microsoft.EntityFrameworkCore.Cosmos](https://www.nuget.org/packages/Aspire.Microsoft.EntityFrameworkCore.Cosmos) | A library for accessing Azure Cosmos DB databases with [Entity Framework Core](/ef/core/providers/cosmos/). |
| <img src="media/icons/AzureCosmosDB_256x.png" alt="Azure Cosmos DB logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure Cosmos DB](../database/azure-cosmos-db-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.CosmosDB](https://www.nuget.org/packages/Aspire.Hosting.Azure.CosmosDB)<br>- **Client**: [📦 Aspire.Microsoft.Azure.Cosmos](https://www.nuget.org/packages/Aspire.Microsoft.Azure.Cosmos) | A library for accessing [Azure Cosmos DB](/azure/cosmos-db/introduction) databases. |
| <img src="media/icons/AzureEventHubs_256x.png" alt="Azure Event Hubs logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure Event Hubs](../messaging/azure-event-hubs-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.EventHubs](https://www.nuget.org/packages/Aspire.Hosting.Azure.EventHubs)<br>- **Client**: [📦 Aspire.Azure.Messaging.EventHubs](https://www.nuget.org/packages/Aspire.Azure.Messaging.EventHubs) | A library for accessing [Azure Event Hubs](/azure/event-hubs/event-hubs-about). |
| <img src="media/icons/AzureKeyVault_256x.png" alt="Azure Key Vault logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure Key Vault](../security/azure-security-key-vault-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.KeyVault](https://www.nuget.org/packages/Aspire.Hosting.Azure.KeyVault)<br>- **Client**: [📦 Aspire.Azure.Security.KeyVault](https://www.nuget.org/packages/Aspire.Azure.Security.KeyVault) | A library for accessing [Azure Key Vault](/azure/key-vault/general/overview). |
| <img src="media/icons/AzureLogAnalytics_256x.png" alt="Azure Operational Insights logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure Operational Insights](https://github.com/dotnet/aspire/blob/main/src/Aspire.Hosting.Azure.OperationalInsights/README.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.OperationalInsights](https://www.nuget.org/packages/Aspire.Hosting.Azure.OperationalInsights)<br>- **Client**: N/A | A library for interacting with [Azure Operational Insights](/azure/azure-monitor/logs/log-analytics-workspace-overview). |
| <img src="media/icons/AzureOpenAI_256x.png" alt="Azure OpenAI logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure AI OpenAI](../azureai/azureai-openai-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.CognitiveServices](https://www.nuget.org/packages/Aspire.Hosting.Azure.CognitiveServices)<br>- **Client**: [📦 Aspire.Azure.AI.OpenAI](https://www.nuget.org/packages/Aspire.Azure.AI.OpenAI) | A library for accessing [Azure AI OpenAI](/azure/ai-services/openai/overview) or OpenAI functionality. |
| <img src="media/icons/AzurePostgreSQL_256x.png" alt="Azure PostgreSQL logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure PostgreSQL](https://github.com/dotnet/aspire/blob/main/src/Aspire.Hosting.Azure.PostgreSQL/README.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.PostgreSQL](https://www.nuget.org/packages/Aspire.Hosting.Azure.PostgreSQL)<br>- **Client**: N/A | A library for interacting with [Azure Database for PostgreSQL](/azure/postgresql/). |
| <img src="media/icons/AzureSearch_256x.png" alt="Azure AI Search Documents logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure AI Search](../azureai/azureai-search-document-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.Search](https://www.nuget.org/packages/Aspire.Hosting.Azure.Search)<br>- **Client**: [📦 Aspire.Azure.Search.Documents](https://www.nuget.org/packages/Aspire.Azure.Search.Documents) | A library for accessing [Azure AI Search](/azure/search/search-what-is-azure-search) functionality. |
| <img src="media/icons/AzureServiceBus_256x.png" alt="Azure Service Bus logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure Service Bus](../messaging/azure-service-bus-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.ServiceBus](https://www.nuget.org/packages/Aspire.Hosting.Azure.ServiceBus)<br>- **Client**: [📦 Aspire.Azure.Messaging.ServiceBus](https://www.nuget.org/packages/Aspire.Azure.Messaging.ServiceBus) | A library for accessing [Azure Service Bus](/azure/service-bus-messaging/service-bus-messaging-overview). |
| <img src="media/icons/AzureSignalR_256x.png" alt="Azure SignalR Service logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure SignalR Service](../real-time/azure-signalr-scenario.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.SignalR](https://www.nuget.org/packages/Aspire.Hosting.Azure.SignalR)<br>- **Client**: [Microsoft.Azure.SignalR](https://www.nuget.org/packages/Microsoft.Azure.SignalR) | A library for accessing [Azure SignalR Service](/azure/azure-signalr/signalr-overview). |
| <img src="media/icons/AzureStorageContainer_256x.png" alt="Azure Blog Storage logo."  role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure Blob Storage](../storage/azure-storage-blobs-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.Storage](https://www.nuget.org/packages/Aspire.Hosting.Azure.Storage)<br>- **Client**: [📦 Aspire.Azure.Storage.Blobs](https://www.nuget.org/packages/Aspire.Azure.Storage.Blobs) | A library for accessing [Azure Blob Storage](/azure/storage/blobs/storage-blobs-introduction). |
| <img src="media/icons/AzureStorageQueue_256x.png" alt="Azure Storage Queues logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure Storage Queues](../storage/azure-storage-queues-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.Storage](https://www.nuget.org/packages/Aspire.Hosting.Azure.Storage)<br>- **Client**: [📦 Aspire.Azure.Storage.Queues](https://www.nuget.org/packages/Aspire.Azure.Storage.Queues) | A library for accessing [Azure Storage Queues](/azure/storage/queues/storage-queues-introduction). |
| <img src="media/icons/AzureTable_256x.png" alt="Azure Table Storage logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure Table Storage](../storage/azure-storage-tables-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.Storage](https://www.nuget.org/packages/Aspire.Hosting.Azure.Storage)<br>- **Client**: [📦 Aspire.Azure.Data.Tables](https://www.nuget.org/packages/Aspire.Azure.Data.Tables) | A library for accessing the [Azure Table](/azure/storage/tables/table-storage-overview) service. |
| <img src="media/icons/AzureWebPubSub_256x.png" alt="Azure Web PubSub logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 Azure Web PubSub](../messaging/azure-web-pubsub-integration.md) <br/> - **Hosting**: [📦 Aspire.Hosting.Azure.WebPubSub](https://www.nuget.org/packages/Aspire.Hosting.Azure.WebPubSub)<br>- **Client**: [📦 Aspire.Azure.Messaging.WebPubSub](https://www.nuget.org/packages/Aspire.Azure.Messaging.WebPubSub) | A library for accessing the [Azure Web PubSub](/azure/azure-web-pubsub/) service. |
<!-- markdownlint-enable MD033 MD045 -->

> [!IMPORTANT]
> The .NET Aspire Azure hosting libraries rely on `Azure.Provisioning.*` libraries to provision Azure resources. For more information, [Azure provisioning libraries](../deployment/azure/local-provisioning.md).

### AWS hosting integrations

<!-- markdownlint-disable MD033 MD045 -->
| Integration | Docs and NuGet packages | Description |
|--|--|--|
| <img src="media/icons/AWS.png" alt="AWS logo." role="presentation" width="78" data-linktype="relative-path"> | - **Learn more**: [📄 AWS Hosting](https://github.com/dotnet/aspire/blob/main/src/Aspire.Hosting.AWS/README.md) <br/> - **Hosting**: [📦 Aspire.Hosting.AWS](https://www.nuget.org/packages/Aspire.Hosting.AWS)<br>- **Client**: N/A | A library for modeling [AWS resources](https://aws.amazon.com/cdk/). |
<!-- markdownlint-enable MD033 MD045 -->

For more information, see [GitHub: Aspire.Hosting.AWS library](https://github.com/dotnet/aspire/tree/main/src/Aspire.Hosting.AWS).

## Cloud-native features

Cloud-native applications surface many unique requirements and concerns. The core features of .NET Aspire orchestration and integrations are designed to handle many cloud-native concerns for you with minimal configurations. Some of the key features include:

- [Orchestration](app-host-overview.md): A lightweight, extensible, and cross-platform app host for .NET Aspire projects. The app host provides a consistent configuration and dependency injection experience for .NET Aspire integrations.
- [Service discovery](../service-discovery/overview.md): A technique for locating services within a distributed application. Service discovery is a key integration of microservice architectures.
- [Service defaults](service-defaults.md): A set of default configurations intended for sharing among resources within .NET Aspire projects. These defaults are designed to work well in most scenarios and can be customized as needed.

Some .NET Aspire integrations also include more capabilities for specific services or platforms, which can be found in the integration specific reference docs.

### Observability and telemetry

.NET Aspire integrations automatically set up Logging, Tracing, and Metrics configurations, which are sometimes known as _the pillars of observability_.

- **[Logging](/dotnet/core/diagnostics/logging-tracing)**: A technique where code is instrumented to produce logs of interesting events that occurred while the program was running. A baseline set of log events is enabled for .NET Aspire integrations by default and more extensive logging can be enabled on-demand to diagnose particular problems.

- **[Tracing](/dotnet/core/diagnostics/distributed-tracing)**: A specialized form of logging that helps you localize failures and performance issues within applications distributed across multiple machines or processes. This technique tracks requests through an application to correlate work done by different application integrations and separate it from other work the application may be doing for concurrent requests.

- **[Metrics](/dotnet/core/diagnostics/metrics)**: Numerical measurements recorded over time to monitor application performance and health. Metrics are often used to generate alerts when potential problems are detected. Metrics have low performance overhead and many services configure them as always-on telemetry.

Together, these types of telemetry allow you to gain insights into your application's behavior and performance using various monitoring and analysis tools. Depending on the backing service, some integrations might only support some of these features. For example, some integrations support logging and tracing, but not metrics. Telemetry features can also be disabled. For more information, see [.NET Aspire service defaults](service-defaults.md).

### Health checks

.NET Aspire integrations enable health checks for services by default. Health checks are HTTP endpoints exposed by an app to provide basic availability and state information. These endpoints can be configured to report information used for various scenarios:

- Influence decisions made by container orchestrators, load balancers, API gateways, and other management services. For instance, if the health check for a containerized app fails, it might be skipped by a load balancer routing traffic.
- Verify that underlying dependencies are available, such as a database or cache, and return an appropriate status message.
- Trigger alerts or notifications when an app isn't responding as expected.

For example, the [Service defaults](service-defaults.md) configures a health endpoint at the `/health` URL path. The .NET Aspire PostgreSQL client integration automatically adds a health check into that endpoint to verify the following:

- A database connection could be established
- A database query could be executed successfully

If either of these operations fail, the health check also fails. For more information, see [Health checks in .NET Aspire](health-checks.md).

### Resiliency

.NET Aspire integrations enable resiliency configurations automatically where appropriate. Resiliency is the ability of your system to react to failure and still remain functional. Resiliency extends beyond preventing failures to include recovering and reconstructing your cloud-native environment back to a healthy state. Examples of resiliency configurations include:

- **Connection retries**: You can configure some .NET Aspire integrations to retry requests that initially fail. For example, failed database queries can be retried multiple times if the first request fails. This creates tolerance in environments where service dependencies may be briefly unresponsive or unavailable when the system state changes.

- **Timeouts**: You can configure how long an .NET Aspire integration waits for a request to finish before it times out. Timeout configurations can be useful for handling dependencies with variable response times.

For more information, see [Build resilient HTTP apps](/dotnet/core/resilience/http-resilience).

## What is an MCP Server?

A Model Context Protocol (MCP) server is a specialized service that extends functionality by providing additional tools and resources through a standardized protocol. There are two types:

1. Local (Stdio-based) servers: Run on the user's machine and communicate via standard input/output
2. Remote (SSE-based) servers: Run on remote machines and communicate via Server-Sent Events over HTTP/HTTPS

MCP servers can:
- Provide custom tools for specific tasks
- Expose external APIs and services
- Share resources and data across different parts of an application
- Enable real-time communication and updates

# OpenBanking Product MCP

An OpenBanking integration service that handles product data interactions with banking APIs, specifically designed for Commonwealth Bank of Australia (CBA) product endpoints.

## Features

- Product data retrieval from CBA OpenBanking APIs
- DTOs for standardized OpenBanking product responses
- Service layer abstraction for product operations
- Proxy pattern implementation for bank-specific integrations

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (compatible with project version)
- [Visual Studio Code](https://code.visualstudio.com/)

## Project Structure

```
OpenbankingProductMcp/
├── Dtos/
│   └── OpenbankingProducts/     # Data Transfer Objects
│       └── Dtos.cs             
├── Proxies/                     # Bank-specific API proxies
│   ├── CbaProductProxy.cs       # CBA implementation
│   └── IProductProxy.cs         # Interface definition
├── Services/                    # Business logic layer
│   └── CbaProductsService.cs
├── EchoProduct.cs              # Product echo functionality
└── Program.cs                  # Application entry point
```

## Getting Started

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd OpenbankingProductMcp
   ```

2. Open in VS Code:
   ```bash
   code .
   ```

3. Restore dependencies:
   ```bash
   dotnet restore
   ```

4. Build the project:
   ```bash
   dotnet build
   ```

5. Run the application:
   ```bash
   dotnet run
   ```

## Configuration

- [Set Up MCP Servers in VSCode for GitHub Copilot](https://www.youtube.com/watch?v=wPgI6kxGnHw&t=12s) - Set Up MCP Servers in VSCode for GitHub Copilot (Agent Mode) in Just 5 Minutes!

## Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## Useful Links

- [Consumer Data Standards Australia](https://consumerdatastandardsaustralia.github.io/standards/index.html) - Official documentation for Australian Open Banking standards and APIs
- [Building MCP Servers in C#](https://devblogs.microsoft.com/dotnet/build-a-model-context-protocol-mcp-server-in-csharp/) - Microsoft's guide on implementing MCP servers using C#
- [Model Context Protocol](https://github.com/modelcontextprotocol) - Official GitHub organization for MCP development and standards
- [MCP Server Examples](https://github.com/modelcontextprotocol/servers) - Reference implementations and examples of MCP servers
- [MCPDotNet](https://github.com/PederHP/mcpdotnet) - .NET implementation of the Model Context Protocol with examples and utilities
- [MCP C# SDK](https://github.com/modelcontextprotocol/csharp-sdk) - Official C# SDK for building Model Context Protocol servers and clients

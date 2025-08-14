# ASP.NET Core 8 Web API Resilience Demo with Polly

A practical demo project showcasing how to build **resilient, fault-tolerant HTTP clients** in ASP.NET Core 8 using [Polly](https://github.com/App-vNext/Polly).

---

## Features

- ASP.NET Core 8 Web API  
- HttpClient with Polly integration  
- Retry with exponential backoff  
- Circuit breaker to prevent cascading failures  
- Timeout policy to cancel slow requests  
- Fallback policy for graceful degradation  
- Clean and minimal architecture  
- Ready to run with Visual Studio 2022  
- Easily extensible for real-world APIs  

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)  
- Visual Studio 2022 (latest update)  

### Setup

1. Clone the repo:

   ```bash
   git clone https://github.com/yourusername/AspNetCore8-Polly-Resilience-Demo.git
   cd AspNetCore8-Polly-Resilience-Demo
Open the solution in Visual Studio 2022.

Restore dependencies and build the project.

Run the project (F5 or Ctrl+F5).

Navigate to https://localhost:{port}/swagger to explore and test the API.

API Endpoints
Method	Endpoint	Description
GET	/api/weather	Calls an unreliable external API with resilience policies applied

How It Works
The HttpClient used to call an unreliable external API is wrapped with Polly policies:

Retry: Automatically retries failed requests with exponential delays.

Circuit Breaker: Stops sending requests after consecutive failures to prevent overload.

Timeout: Cancels any request that takes too long.

Fallback: Returns default data if the external API is down or unreachable.

Technologies Used
.NET 8

Polly

ASP.NET Core Web API

Visual Studio 2022

Contribution
Contributions are welcome! Feel free to open issues or submit pull requests.



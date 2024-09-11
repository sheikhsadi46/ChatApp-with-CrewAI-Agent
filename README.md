# Chat with CrewAI Agent using ASP.NET Core, SignalR, and Ollama (Llama2 Model)

This project is a real-time chat interface where users can interact with a CrewAI Agent powered by the Ollama model (Llama2). The chat interface allows messages to be sent between the current user ("Me") and the AI agent, with a clean and responsive chat UI.

## Features

- Real-time chat using **SignalR**.
- AI responses powered by the **Ollama** model (Llama2).
- Customizable chat interface with user-friendly features like dynamic input.


## Folder Structure

```text
├── ChatApp
│   ├── Controllers
│   │   └── ChatController.cs        # Manages chat interactions.
│   ├── Hubs
│   │   └── ChatHub.cs               # SignalR hub for real-time messaging.
│   ├── Models
│   │   └── Conversation.cs          # Model to handle chat messages.
│   ├── Services
│   │   └── OllamaService.cs         # Handles communication with the Ollama API.
│   ├── Views
│   │   └── Chat
│   │       └── Index.cshtml         # Front-end chat interface.
├── Program.cs                        # Application startup configuration.
├── appsettings.json                  # App configuration file (excluding database).
```



### Prerequisites

- **.NET SDK 6.0 or later** installed. [Download here](https://dotnet.microsoft.com/en-us/download/dotnet)
- **Ollama** installed locally with the Llama2 model. [Download Ollama](https://ollama.com/)

### Setup Instructions

1. **Clone the Repository**

   Clone this repository to your local machine:

   ```bash
   git clone https://github.com/sheikhsadi46/ChatApp-with-CrewAI-Agent.git
   ```

2. **Install Dependencies**

   Navigate to the project directory and install the necessary NuGet packages by running the following command:

   ```bash
   dotnet restore
   ```

3. **Download and Install Ollama with Llama2 Model**

   Ollama is used to interact with the Llama2 model for generating AI responses. To download and run the model:

   - **Download Ollama** from [here](https://ollama.com/).
   - Once installed, download the Llama2 model by running the following command in your terminal:

     ```bash
     ollama pull llama2:7b
     ```

   - Start the Ollama service using:

     ```bash
     ollama serve
     ```

   By default, Ollama runs on `http://localhost:11434`. Make sure this endpoint is up and running before starting the chat application.

4. **Run the Project**

   Now, run the project by using the following command in the root directory:

   ```bash
   dotnet run
   ```

### Libraries Used

- **ASP.NET Core MVC**: For building the web application framework.
- **SignalR**: For real-time web functionality to support live chat.
```bash
Microsoft.AspNetCore.SignalR
  ```
- **HttpClient**: To communicate with the Ollama API to get responses from the Llama2 model. 
```bash
System.Net.Http.Json
```
- **Ollama API**: For interacting with the Llama2 AI model.

### Running Ollama

After ensuring that Ollama is running, you can check its status by hitting the following curl command in Command Prompt:

```bash
curl http://localhost:11434/v1/chat/completions -H "Content-Type: application/json" -d "{\"model\": \"llama2\", \"messages\": [{\"role\": \"system\", \"content\": \"You are a helpful assistant.\"}, {\"role\": \"user\", \"content\": \"Hello!\"}]}"
```

If the setup is successful, you should get a response from the Llama2 model.

## Screenshots

![Chat Avatar 0](https://github.com/sheikhsadi46/ChatApp-with-CrewAI-Agent/raw/master/Images/0.jpeg "Avatar 0")

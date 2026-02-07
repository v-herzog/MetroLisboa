# MetroLisboa

A real-time page providing live arrival times for every metro line across the **Metropolitano de Lisboa** network.

* Direct integration with Lisbon Metro's API for live "next train" predictions.
* Support for almost all stations across the Blue, Yellow, Green, and Red lines.
* Directional indication of train destinations.
* Map of the metro network.

<img width="385" height="797" alt="Screenshot" src="https://github.com/user-attachments/assets/37257f33-5b98-407f-bab5-eae6e775152e" />

## Getting Started

### Prerequisites
* .NET 8
* A free API key from the [https://api.metrolisboa.pt/](https://api.metrolisboa.pt/store/apis/info?name=EstadoServicoML&version=1.0.1&provider=admin)

### Run the application
* Create an `appsettings.Development.json` file based on the existing `appseetings.json`.
* Paste into it the `BaseAddress` and `Authorization` values you got from the api.metrolisboa.pt website.
* Run the app.

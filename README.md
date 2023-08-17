# DealStore web Based on Microservice architecture and ready for Native Cloud .

> The PoC prototype of Automated Irregularity Management System Architecture (illustrated in Figure 4.4.1) is designed around the principles of a Microservices architecture and provides scalability, modularity as well as flexibility. This architecture is orchestrated through Kubernetes which ensures seamless container orchestration, auto-scaling, and efficient resource management. The system comprises several key components, each operating in its own containerized environment:

>Frontend Container:
The Frontend container is responsible for the user interface and interaction with passengers. It offers a user-friendly interface accessible through touch screen terminals. Passengers can conveniently interact with the system, request information, and select options for managing irregularities.

Booking-API Container:
The Booking-API container serves as the communication interface between the user interface and the backend services. It handles passenger requests, initiates booking-related operations, and provides real-time updates to users. This component plays a pivotal role in efficiently processing passenger requests.

Provider-API Container:
The Provider-API container interfaces with external service providers, such as hotels, restaurants, and transportation services. It communicates reservation and service requests to external providers and manages the responses to ensure seamless integration of services and timely updates to passengers.

System-API Container:
The System-API container is responsible for the core functionality of the irregularity management system. It orchestrates communication between various microservices, manages data flow, and ensures the integrity of the system's operations. This component is vital for maintaining the overall functionality and reliability of the system.

The database used for storing relevant data is Azure SQL managed service. This choice ensures data security, reliability, and efficient data management. The system's performance, operations, and user interactions are continuously monitored using Grafana for visualization, LOKI for log aggregation, and Zipkin for distributed tracing. These monitoring tools collectively provide insights into system health, usage patterns, and potential issues, facilitating prompt responses and improvements.

The development process for the PoC System occurs within the Azure DevOps platform. It encompasses collaborative coding, continuous integration (CI), and continuous delivery (CD) pipelines. CI/CD pipelines automate the building, testing, and deployment processes, enabling rapid iterations, minimizing errors, and ensuring smooth deployment to Azure.

The PoC Architecture leverages a Microservices approach orchestrated through Kubernetes, providing the necessary modularity and scalability to efficiently handle passenger irregularity management. The use of Azure SQL managed service ensures data reliability, while monitoring tools like Grafana, LOKI, and Zipkin contribute to efficient system management. The development process on Azure DevOps, along with CI/CD pipelines, streamlines development and deployment, ultimately resulting in a reliable, user-friendly, and highly functional irregularity management system.



#### The demo exposes the following backends:

### App   


    Frontend at http://localhost:8080/
    Backend Provider API at http://localhost:8081/
    Backend Deal API at http://localhost:8082/
    Backend System API at http://localhost:8083/


  

### Monitor Tools
    Grafana Tools:
    Grafana at  http://0.0.0.0:3000/
    LOKI at http://0.0.0.0:3100/status
    

    OpenTelemtry Tools :
    Jaeger at http://0.0.0.0:16686
    Zipkin at http://0.0.0.0:9411
    

### Run the demo local




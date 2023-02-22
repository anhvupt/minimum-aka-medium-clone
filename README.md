# Minimum AKA Medium Clone

A simple clone of Medium.com, built as a demo application for job interview purposes. The application is built using modern technologies, and showcases the ability to design, implement and deploy a scalable web application.

## Requirements

The following functional requirements were identified for the Minimum AKA Medium Clone:

- User authentication and registration
- Profile creation and management
- Content creation and management
- Content discovery and search functionality
- User feeds and recommendations

The following non-functional requirements were also identified:

- High availability and scalability
- Fast load times for both read and write operations
- Robust security to prevent data breaches and unauthorized access
- Support for large amounts of data

## Assumptions and Calculations

The following assumptions were made during the design and planning of the application:

- 10 million users in total, with 1 million active users per day
- Each user posts 2 posts per day, with an average of 1000 words and 3-5 images per post
- Total storage requirement of 6.5 petabytes per year
- Required bandwidth of 95 megabytes per second
- Sharding of MongoDB database for scalability
- Use of Azure platform for hosting and deployment

## Tech Stack

The Minimum AKA Medium Clone is built using the following technologies:

- .NET Core for the backend API
- React.js for the frontend UI
- MongoDB for the database
- Azure for hosting and deployment

## Main Components

The application consists of the following main components:

- Authentication and Authorization module
- Content Creation and Management module
- Search and Discovery module
- Recommendation module
- Storage and Caching module
- Frontend User Interface

## Caching

Caching will be implemented in the application to improve performance and reduce the number of database queries. Redis will be used as a caching layer to store frequently accessed data.

## Testing

Integration testing will be used to ensure that all the components of the application are working correctly and communicating with each other as expected.

## Final Thoughts

The Minimum AKA Medium Clone is a scalable, performant web application that can handle large amounts of data and traffic. It is designed to showcase modern web technologies and the ability to design and implement complex systems.

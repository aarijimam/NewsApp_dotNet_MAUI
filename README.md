# .NET Maui News App

## Overview

Welcome to the .NET Maui News App! This dynamic application offers users a seamless experience in accessing news articles tailored to their preferences. Developed using .NET Maui, the app provides a robust framework for cross-platform functionality while integrating SQLite for efficient local database management. One of the app's key features is its utilization of the [News API](https://newsapi.org/), harnessing the power of HTTPS GET requests to fetch real-time news data.

## Features

### Category Selection
Navigate through an extensive array of news categories to discover articles that align with your interests. Whether it's politics, technology, sports, or entertainment, the app ensures that you stay informed on topics that matter to you.

### Article Search
Looking for something specific? Utilize the search functionality to quickly find articles by entering relevant keywords. With just a few taps, access the information you need with ease.

### Favorites Management
Personalize your news reading experience by marking articles as favorites. A simple swipe right enables you to save noteworthy articles for later perusal. Conveniently access your favorite articles through the dedicated favorites icon located in the bottom-right corner.

### Database Implementation
Favourites use SQLite to store the data locally on your device. Add, delete, fetch, search CRUD operations are implemented for smooth operation of Favourites. When Favourites page is loaded it fetches all data from database to load the favourites list.

### Favorites Page
Explore your curated collection of favorite articles in one centralized location. The favorites page provides intuitive controls for managing your saved articles, including options to add, delete, and fetch articles as desired.

### Article Details
Delve deeper into the content that catches your eye by tapping on individual articles. The app seamlessly transitions to a details page, presenting comprehensive information such as the article's title, accompanying image, and insightful content. Additionally, a convenient button allows for seamless navigation to the original article link, providing access to the full story.

## MVVM Implementation in the .NET Maui News App
In the .NET Maui News App, the Model-View-ViewModel (MVVM) architectural pattern is implemented to ensure a well-structured, maintainable, and testable codebase. This architecture separates the application into three distinct layers: Models, Views, and ViewModels, each with its responsibilities. Additionally, services are utilized to encapsulate business logic and promote reusability. Let's explore how MVVM is applied in the app:
### Models (6 Model Classes)

1. ArticleModel
2. CategoryModel
3. FavoritesModel
4. RootModel
5. SourceModel
6. ArticleDBModel

### ViewModels (3 ViewModel Classes)

1. ArticleViewModel
2. CategoryViewModel
3. NewsViewModel

### Views (3 Views)

1. DetailsPage
2. FavouritesPage
3. HomePage

### Services (2 Services)

1. ApiService
2. DatabaseService


## News API Cloud Integration

In the .NET Maui News App, we integrate with the News API from newsapi.org to retrieve real-time news data. This integration falls under cloud integration as it connects our application to an external service hosted on the cloud. As developers, we utilize the free version of the API to access essential functionalities for fetching news articles.

#### Functionality

The News API offers various endpoints that allow us to tailor our news retrieval based on specific parameters:

- **Search**: Users can search for news articles using keywords. We incorporate parameters such as language, country, and topic to narrow down the search results.
- **Language and Country**: Users can specify the language and country preferences for the news articles they wish to view.
- **Topic**: Users can select specific topics of interest, such as politics, technology, sports, or entertainment.
- **Pagination**: The API returns a paginated response, providing up to 20 articles per request.

#### Response Format

The API responds with news articles in JSON format, making it easy for our application to parse and extract relevant information. Each article object typically contains details such as title, description, author, source, published date, and a link to the full article.

#### Usage Limitations

As we're using the free version of the News API for developers, there may be certain limitations to consider, such as request rate limits, daily usage quotas, and restricted access to premium features. However, for the scope of our application, the free tier offers sufficient functionality to meet our needs and provide users with valuable news content.

By integrating with the News API, we enhance the capabilities of our .NET Maui News App, enriching the user experience with timely and relevant news articles sourced from reputable sources across the globe.

## Software Design Patterns

### MVVM (Model-View-ViewModel)

We split our app into three parts:
- **Models**: These hold the data, like news articles and user info.
- **Views**: This is what users see and interact with, like the screens showing news articles.
- **ViewModels**: They connect the models and views, handling stuff like fetching news and updating the screen.

### Repository Pattern

We keep our data separate from the rest of the app. So when we need to save or get news articles, we have a special place (repository) to handle that without making a mess elsewhere.

### Dependency Injection

This helps us manage who talks to whom. If one part of the app needs help from another part, we use dependency injection to make that happen without causing confusion or chaos.

### Command Pattern

We turn user actions (like tapping on an article) into little packages called commands. This makes it easier to handle what happens when users do things, like saving articles or opening links.

### Singleton Pattern

Certain important things (like the database where we keep our articles) should only exist in one place at a time. So, we use the Singleton pattern to make sure there's only one of them, avoiding any mix-ups.

By using these tricks, our app stays organized, works smoothly, and makes life easier for both users and developers.

## Screenshots

![image](https://github.com/aarijimam/NewsApp/assets/35100854/3dfeaa02-a87d-42c7-a34f-10a916e43068)
![image](https://github.com/aarijimam/NewsApp/assets/35100854/30ceae73-8625-43d9-800f-1df7b0954a33)
![image](https://github.com/aarijimam/NewsApp/assets/35100854/90320858-227b-4459-80b1-34cdc352d5c0)
![image](https://github.com/aarijimam/NewsApp/assets/35100854/b0b241f5-ef6a-4a18-8af6-e17f16562e91)
![image](https://github.com/aarijimam/NewsApp/assets/35100854/36cade9d-9acb-4b06-a2c3-7355d9ff2b3d)
![image](https://github.com/aarijimam/NewsApp/assets/35100854/46f11c06-5012-416d-9bc4-0c694337606a)

## Installation

Getting started with the .NET Maui News App is a breeze! Follow these simple steps to set up the application on your device:

1. **Clone the Repository**: Begin by cloning the project repository to your local machine using the following command:
   ```
   git clone https://github.com/CezarAmanedddine/6002CEM_CezarAmanedddine.git
   ```

2. **Navigate to the Project Directory**: Use the terminal or command prompt to navigate to the cloned repository directory:
   ```
   cd your-repository
   ```

3. **Restore NuGet Packages**: Restore the necessary NuGet packages by executing the following command:
   ```
   dotnet restore
   ```

4. **Build and Run the Application**: Build the project and launch the application using the following commands:
   ```
   dotnet build
   dotnet run
   ```

## Dependencies

The .NET Maui News App leverages a range of dependencies to deliver its robust functionality:

- **.NET Maui**: Empowering cross-platform development with a unified framework.
- **SQLite**: Providing seamless local database storage for efficient data management.
- **News API**: Harnessing the power of real-time news data through HTTPS GET requests.
- _Insert any additional dependencies or libraries used within the application._

## Usage

Discovering and consuming news content has never been more effortless. Here's how to make the most of the .NET Maui News App:

1. **Explore Categories**: Upon launching the app, dive into an extensive selection of news categories to find articles that pique your interest.
2. **Search for Articles**: Need to find something specific? Utilize the search feature to quickly locate articles based on keywords relevant to your query.
3. **Mark Favorites**: Swipe right on any article to mark it as a favorite and add it to your personalized collection.
4. **Access Favorites**: Easily access your favorite articles through the dedicated favorites icon located in the bottom-right corner of the screen.
5. **Manage Favorites**: Head to the favorites page to manage your curated collection of favorite articles. Perform actions such as adding, deleting, and fetching articles with intuitive controls.
6. **Explore Article Details**: Tap on any article to delve deeper into its content. Discover insightful details, including the article's title, accompanying image, and full content. With the tap of a button, seamlessly navigate to the original article link for further reading.

## Contributing

Contributions to the .NET Maui News App are highly valued and welcomed! If you're interested in contributing to the project, here's how you can get involved:

1. **Fork the Repository**: Begin by forking the project repository to your GitHub account.
2. **Create a New Branch**: Set up a new branch for your contributions, ensuring isolation and ease of collaboration.
3. **Make Your Changes**: Implement your desired features, enhancements, or bug fixes within the new branch.
4. **Commit Your Changes**: Once your changes are complete, commit them with clear and descriptive messages.
5. **Push Your Changes**: Push your committed changes to your forked repository.
6. **Create a Pull Request**: Finally, create a pull request to propose your changes for review and integration into the main project.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgements

The .NET Maui News App extends its gratitude to the following individuals and resources for their invaluable contributions and support:

- **News API**: Providing access to real-time news data, enriching the app's content and functionality.
- _Insert any additional acknowledgments or credits here._

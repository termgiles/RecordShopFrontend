# RecordShopFrontend

This website uses popular albums to help the user in learning French vocabularly. Simple database operations are provided in a mix of French and English, allowing the user to interact with the albums.<br/>

Technology<br/>
The website is built using MS blazor with interactivity provided by C# complied to WASM. Styling is provieded with a mix of Bulma and custom CSS classes.

The project is paired with a backed which provides RESTful Api endpoint for create, read, update, and delete operations as well as query operations on albums in a databse. Most rendering occurs server-side.

To do
- Further develop client side rendering<br/>
- Integrate Google Cloud Translate Api to warn the user if album entries are not (discernably) French

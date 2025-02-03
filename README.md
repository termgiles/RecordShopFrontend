# RecordShopFrontend

This website uses popular albums to help you learning French vocabularly. Simple database operations are provided in a mix of French and English, allowing you to interact with the albums. Please add albums in French (no matter how bad; deliberate over-translation welcome!)<br/>

Technology<br/>
The website is built using ms blazor with interactivity provided by C# complied to WASM. Styling is provieded with a mix of Bulma and custom CSS classes.

The project is paired with a backed which provides RESTful Api contacts for create, read, update, and delete as well as query operations on albums in a databse. Most rendering is currently client-side.

##To do
- Further develop client side rendering<br/>
- Integrate Google Cloud Translate Api to warn the user if album entries are not (discernably) French

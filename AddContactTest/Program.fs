open canopy
open runner
open System

//start an instance of the firefox browser
start firefox
let userName="//input[@type='email']"
let password="//input[@type='password']"
let addNewContact="//i[@class='md md-add']"
let firstName="//input[@name='firstName']"
let lastName="//input[@name='lastName']"
let email="//input[@name='email']"
let state="//input[@name='state']"
let contactAdded="//div[@class='toast-message']"
let dashBoard="//span[@class='title']"
let button="//button[@class='btn btn-default-light dropdown-toggle ng-binding']"
let emptyEmail="//span[@class='help-block ng-binding']"
let search="//input[@type='search']"
let verifyAddingContact="//div[@class='dataTables_info']"


//this is how you define a test
"taking canopy for a spin" &&& fun _ ->
    //this is an F# function body, it's whitespace enforced

    //go to url

    url "http://sophiafiori.azurewebsites.net/#/"
    click userName
    userName  << "faisal@foothillsolutions.com"
    click password 
    password << "foobar"
    click "Login"    
    button  == "QA TEMPLATE"
    url "http://sophiafiori.azurewebsites.net/#/contacts"
    click addNewContact
    click firstName
    firstName << "Mahmoudd"
    click lastName 
    lastName << "Sami"
    click email
    email << "mahmoud-samiiiiiiiiii@hotmail.com"
    click state
    state << "mmm"
    click "Save"
    contactAdded == "Contact Added Successfully"
    click search
    search << "mahmoud-samiiiiiiiiii@hotmail.com"
    verifyAddingContact=="Showing 1 to 1 of 1 entries"



//run all tests
run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()

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
    sleep 9
    url "http://sophiafiori.azurewebsites.net/#/contacts"
    sleep 2
    click addNewContact
    sleep 2
    click firstName
    firstName << "Mahmoudd"
    click lastName 
    lastName << "Sami"
    click email
    email << "mahmoud-samiii@hotmail.com"
    click state
    state << "mmm"
    click "Save"
    click "Contacts"



//run all tests
run()

printfn "press [enter] to exit"
System.Console.ReadLine() |> ignore

quit()

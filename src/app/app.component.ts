import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'louliaPastry';
  ngOnInit(): void {
  
  }
  showMenu(){
    let navOptions = document.getElementById('options')
    if (navOptions?.classList.toString() == "optionsClosed"){
      navOptions.classList.remove("optionsClosed")
      navOptions.classList.toggle("options")
    }
    else if (navOptions?.classList.toString() == "options"){
      navOptions.classList.remove("options")
      navOptions.classList.toggle("optionsClosed")
    }
    let theCookie = document.getElementById('theCookie')
    if (theCookie?.classList.toString() == "cookie"){
      theCookie.classList.remove("cookie")
      theCookie.classList.toggle("cookieFlipped")
    }
    else if (theCookie?.classList.toString() == "cookieFlipped"){
      theCookie.classList.remove("cookieFlipped")
      theCookie.classList.toggle("cookie")
    }
  }
  close() {
    let navOptions = document.getElementById('options')
    if (navOptions?.classList.toString() == "options"){
      navOptions.classList.remove("options")
      navOptions.classList.toggle("optionsClosed")
    }
  }

}

import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
})
export class HeaderComponent implements OnInit {
  form: FormGroup;

  constructor(private formbuilder: FormBuilder) {
    this.form = this.formbuilder.group({
      emailUsuario: ['', [Validators.required]],
      password: ['', [Validators.required]],
    });
  }

  ngOnInit(): void {}

  guardarUsuarios() {
    console.log(this.form);
  }
}

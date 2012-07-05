// The MIT License
// 
// Copyright (c) 2012 Jordan E. Terrell
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

namespace iSynaptic.MvcBootstrap.Models
{
    public class SignInFormModel
    {
        private String _IdLabel;
        private String _PasswordLabel;
        private String _RememberMeLabel;
        private String _SubmitButtonLabel;

        private String _IdControlName;
        private String _PasswordControlName;
        private String _RememberMeControlName;

        public String Id { get; set; }
        public String Password { get; set; }
        public Boolean RememberMe { get; set; }

        public String FormId { get; set; }

        public String IdLabel
        {
            get { return !String.IsNullOrWhiteSpace(_IdLabel) ? _IdLabel : "Username:"; }
            set { _IdLabel = value; }
        }

        public String PasswordLabel
        {
            get { return !String.IsNullOrWhiteSpace(_PasswordLabel) ? _PasswordLabel : "Password:"; }
            set { _PasswordLabel = value; }
        }

        public String RememberMeLabel
        {
            get { return !String.IsNullOrWhiteSpace(_RememberMeLabel) ? _RememberMeLabel : "Remember me"; }
            set { _RememberMeLabel = value; }
        }

        public String SubmitButtonLabel
        {
            get { return !String.IsNullOrWhiteSpace(_SubmitButtonLabel) ? _SubmitButtonLabel : "Sign In"; }
            set { _SubmitButtonLabel = value; }
        }

        public String IdControlName
        {
            get { return !String.IsNullOrWhiteSpace(_IdControlName) ? _IdControlName : "username"; }
            set { _IdControlName = value; }
        }

        public String PasswordControlName
        {
            get { return !String.IsNullOrWhiteSpace(_PasswordControlName) ? _PasswordControlName : "password"; }
            set { _PasswordControlName = value; }
        }

        public String RememberMeControlName
        {
            get { return !String.IsNullOrWhiteSpace(_RememberMeControlName) ? _RememberMeControlName : "remember"; }
            set { _RememberMeControlName = value; }
        }
        
        public Boolean SupportsRememberMe { get; set; }
    }
}
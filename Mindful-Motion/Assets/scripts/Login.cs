using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    // input field only accessible by this class, and usable by the editor.
    [SerializeField] 
    private TMP_InputField UsernameInput;
    [SerializeField]
    private TMP_InputField PasswordInput;
    [SerializeField]
    private TMP_InputField EmailInput;
    [SerializeField]
    private TextMeshProUGUI errorMessage;

    //function for signing in
    public void OnSubmitSignIn() 
    {
        string username = UsernameInput.text;
        string password = PasswordInput.text;
        string EmailAddress = EmailInput.text;

        //check if correct
        Debug.Log("USERNAME:" + username);//log to the console
        Debug.Log("password:" + password);//log to the console
        Debug.Log("Email:" + EmailAddress);//log to the console
        string login = CheckLogin(username,password,EmailAddress);
        if (string.IsNullOrEmpty(login))
        {
            Debug.Log("Login");
            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.LogError("ERROR:" + login);
            errorMessage.text = "ERROR: " + login;
        }
    }
    //to check our Login Info to sign in
    private string CheckLogin(string username, string password, string EmailAddress)
    {
        string returnSignin = "";
        if (string.IsNullOrEmpty(username))
        {
            returnSignin = "Please enter your username.";
        }
        else if (string.IsNullOrEmpty(password))
        {
            returnSignin = "Please enter your Password.";
        }
        else if (string.IsNullOrEmpty(EmailAddress))
        {
            returnSignin = "Please enter your Email Address.";
        }
        else
        {
            returnSignin = "";
        }
     
        return returnSignin;

    }
    //Delete the error message once we start typing
    public void DeleteErrorText()
    {
        errorMessage.text = "";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

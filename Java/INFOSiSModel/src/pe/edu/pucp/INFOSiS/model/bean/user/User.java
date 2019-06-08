package pe.edu.pucp.INFOSiS.model.bean.user;

public class User {

    private int id;
    private String username;
    private String password;
    private UserType acces;
    private boolean isActive;

    public User() {
    }

    public User(int id, String username, String password, UserType acces, boolean isActive) {
        this.id = id;
        this.username = username;
        this.password = password;
        this.acces = acces;
        this.isActive = isActive;
    }
    
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public boolean isIsActive() {
        return isActive;
    }

    public void setIsActive(boolean isActive) {
        this.isActive = isActive;
    }

    public UserType getAcces() {
        return acces;
    }

    public void setAcces(UserType acces) {
        this.acces = acces;
    }
    
    


}
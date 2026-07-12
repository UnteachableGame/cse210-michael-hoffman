namespace Foundation2;

public class Address {
    private String _streetAddress;
    private String _city;
    private String _state;
    private String _country;
    private bool _isInUSA;

    public Address(string streetAddress, string city, string state, string country) {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;

        if (_country == "USA") {
            _isInUSA = true;
        } else {
            _isInUSA = false;
        }
    }

    public String GetAddress() {
        return $"{StreetAddress}, {City}, {State}, {Country}";
    }

    public string StreetAddress {
        get => _streetAddress;
        set => _streetAddress = value;
    }

    public string City {
        get => _city;
        set => _city = value;
    }

    public string State {
        get => _state;
        set => _state = value;
    }

    public string Country {
        get => _country;
        set {
            _country = value;

            if (_country == "USA") {
                _isInUSA = true;
            } else {
                _isInUSA = false;
            }
        }
    }

    public bool IsInUSA {
        get => _isInUSA;
        set {
            _isInUSA = value;

            if (_isInUSA) {
                _country = "USA";
            }
        }
    }
}
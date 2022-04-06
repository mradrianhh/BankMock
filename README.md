# BankMock

# Flow

- Open application
	- Login as admin -> Admin home
	- Login as user -> Home
	- Exit -> Closes application

- Home
	- View accounts -> Account screen
	- View bills -> Bills screen
	- Logout -> Open application

- Account screen
	- Transfer -> Transfer screen
	- Delete -> Validate and verify

- Bills screen
	- Pay -> Transfer screen(account, amount)
	- Remove -> Verify action(Are you certain? (Y/N))

- Transfer screen(target account?, amount?)
	- Choose account to transfer to
	- Choose amount to transfer
	- Choose account to transfer from
	- Validate and verify transaction



# Components

User:
	fields:
		- List<BankAccount>
		- First Name
		- Last Name
		- Birthdate
		- Social security number(ID)
		- Phone number
		- Email address.
		- Country
		- Address
		- State
		- Postal number
		- City
		- DateCreated
	methods:


BankAccount:
	fields:
		- AccountNumber(ID)
		- AccountOwner(Social security number)
		- Account type
		- Currency
		- Amount
		- DateCreated
	methods:

Bill:
	fields:
		- KID(ID)
		- TargetAccountNumber
		- InvoiceDescription
		- Amount
		- Currency
		- DueDate
		- Issuer

Transaction:
	fields:
		- TargetAccountNumber
		- SourceAccountNumber
		- Amount
		- Currency
		- Date


# Services

IdentityService:
	- Validate login
	- Create new user.

TransactionService:
	- Return transactions from a given account.
	- Create new transaction.

AccountService:
	- Return bankaccounts for a given user.
	- Create new bankaccount.

BillsService:
	- Return bills for a given user.

# Requirements

User:
	- Throws an InvalidOperationException if the user attempts to delete his last BankAccount.
	- Assert that upon creation, the user has one BankAccount and it is equal to the default BankAccount.
	- Throws an ArgumentNullException if any of the fields are null.
	- Throws an InvalidArgumentException if the BirthDate is such that his age is not greater then or equal to 18 years.
	- Assert that the social security number is valid.

Transaction:
	- Throws an ArgumentNullException if any of the fields are null upon creation.
	- Throws an InvalidArgumentException if the amount is not greater then 0 upon creation.
	- Throws an InvalidArgumentException if the TargetAccountNumber is equal to the SourceAccountNumber upon creation.
	- Throws an AccountNotFoundException if it can't resolve any of the account numbers upon creation.
	- Throws an InvalidOperationException if the transaction amount brings the amount in the SourceAccount below 0.
	- Throws a ConfirmationFailedException if the user decides to not confirm the transaction.
	- Throws a ValidationFailedException if it catches either of the following: ArgumentNullException, InvalidArgumentException, AccountNotFoundException upon creation.
	- Assert that the amount in the TargetAccount has increased by the transaction amount.
	- Assert that the amount in the SourceAccount has decreased by the transaction amount.

BankAccount:
	- Throws an ArgumentNullException if any of the fields are null upon creation.
	- Assert that the amount in the account is 0 upon creation.
	- Throws a ValidationFailedException if it catches an ArgumentNullException upon creation.

Bill:
	- Throws an InvalidArgumentException if it can not resolve the TargetAccountNumber.
	- Throws an ArgumentNullException if any of the fields are 0.
	- Throws an InvalidArgumentException if the amount is less then or equal to 0.
	- Throws an InvalidArgumentException if the DueDate is in the past.


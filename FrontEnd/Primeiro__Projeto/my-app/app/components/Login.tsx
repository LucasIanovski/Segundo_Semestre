export default function login() {
    return (
        <div className="w-[35vw] h-[50vh] bg-gray-200 gap-[5vh] flex flex-col p-8 rounded-xl shadow-xl">
            <h1 className="text-3xl font-semibold text-center ">Bem vindo ao Frontend</h1>
            <p className="text-center"> Faça seu login e acesse nossos conteúdos exclusivos para membros</p>

            <div id= "LoginInputs" className="w-full bg flex flex-col gap-8 px-8 ">
                <div className=" flex flex-col gap-1">
                    <h3 className="font-semibold">Email:</h3>
                    <input
                    type="email"
                    placeholder="email@myemail.com"
                    className="w-full p-2 rounded-lg text-blue-500 outline-blue-500 bg-white border-1 border-gray-200 font-semibold shadow-md"
                    />
                </div>
                <div className=" flex flex-col gap-1">
                    <h3 className="font-semibold">Senha:</h3>
                    <input
                    type="password"
                    placeholder="*****"
                    className="w-full p-2 rounded-lg text-blue-500 outline-blue-500 bg-white border-1 border-gray-200 font-semibold shadow-md"
                    />
                </div>
                
                
            </div>
            <div className="flex flex-col gap-2 px-8 items-center" id= "botoes">
                <input 
                type="submit"
                value="Entrar"
                className="p-2 rounded-lg bg-blue-400 text-white cursor-pointer font-semibold hover:bg-blue-500 transition-ease-in duration-200 shadow-md " 
                />
                <p>
                    Esqueceu sua senha ? <a href="#" className="hover:text-blue-500 houver: underline">Clique aqui </a>
                    para recuperar.

                </p>
            </div>
        </div>
    )
}
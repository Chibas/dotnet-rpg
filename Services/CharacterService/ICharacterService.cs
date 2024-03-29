﻿using System;

namespace dotnet_rpg.Services.CharacterService
{
	public interface ICharacterService
	{
		Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
		Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
	}
}


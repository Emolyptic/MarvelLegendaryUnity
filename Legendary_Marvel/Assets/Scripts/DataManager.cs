using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DataManager : MonoBehaviour {

	public Deck villainDeck;
	public Deck heroDeck;
	public Deck mastermindDeck;
	public Deck woundsDeck;
	public Deck bystanderDeck;
	public Deck shieldDeck;
	public Deck escaped;
	public Deck kO;
	public Schemes gameScheme;
	public Mastermind gameMastermind;
	public int numberOfTwistsPlayed = 0;

	public List<Texture2D> blackWidowTextures;
	public List<Texture2D> captainAmericaTextures;
	public List<Texture2D> cyclopsTextures;
	public List<Texture2D> deadpoolTextures;
	public List<Texture2D> emmaFrostTextures;
	public List<Texture2D> gambitTextures;
	public List<Texture2D> hawkEyeTextures;
	public List<Texture2D> hulkTextures;
	public List<Texture2D> ironManTextures;
	public List<Texture2D> nickFuryTextures;
	public List<Texture2D> rogueTextures;
	public List<Texture2D> spidermanTextures;
	public List<Texture2D> stormTextures;
	public List<Texture2D> thorTextures;
	public List<Texture2D> wolverineTextures;

	public List<Texture2D> mastermindTextures;
	public List<Texture2D> drDoomTextures;
	public List<Texture2D> lokiTextures;
	public List<Texture2D> magnetoTextures;
	public List<Texture2D> redSkullTextures;

	public List<Texture2D> brotherhoodTextures;
	public List<Texture2D> enemiesOfAsgardTextures;
	public List<Texture2D> hydraTextures;
	public List<Texture2D> mastersOfEvilTextures;
	public List<Texture2D> radiationTextures;
	public List<Texture2D> skrullsTextures;
	public List<Texture2D> spiderFoesTextures;
	public List<Texture2D> henchmenTextures;
	public List<Texture2D> schemeTextures;
	

	public int numberOfPlayer;

	public Player currentPlayer;

	public List<Player> playerOrder;
	public List<string> playerNames;

	void Awake(){
		DontDestroyOnLoad(transform.gameObject);//Make this object Persistent
	}
	// Use this for initialization
	void Start () {
		playerOrder = new List<Player>();
		playerNames = new List<string>();

		blackWidowTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/black_widow_silent_sniper_md"),
			(Texture2D)Resources.Load("Textures/black_widow_covert_operation_3_md"),
			(Texture2D)Resources.Load("Textures/black_widow_dangerous_rescue_5_md"),
			(Texture2D)Resources.Load("Textures/black_widow_mission_accomplished_5_md")};

		captainAmericaTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/captain_america_day_any_other_md"),
			(Texture2D)Resources.Load("Textures/captain_america_diving_block_3_md"),
			(Texture2D)Resources.Load("Textures/captain_america_avengers_assemble_5_md"),
			(Texture2D)Resources.Load("Textures/captain_america_perfect_teamwork_5_md")};

		cyclopsTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/cyclops_xmen_united_md"),
			(Texture2D)Resources.Load("Textures/cyclops_unending_energy_3_md"),
			(Texture2D)Resources.Load("Textures/cyclops_optic_blast_5_md"),
			(Texture2D)Resources.Load("Textures/cyclops_determination_5_md")};

		deadpoolTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/deadpool_random_unkindness_md"),
			(Texture2D)Resources.Load("Textures/deadpool_can_doover_3_md"),
			(Texture2D)Resources.Load("Textures/deadpool_oddball_5_md"),
			(Texture2D)Resources.Load("Textures/deadpool_here_hold_this_5_md")};

		emmaFrostTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/emma_frost_diamond_form_md"),
			(Texture2D)Resources.Load("Textures/emma_frost_psychic_link_3_md"),
			(Texture2D)Resources.Load("Textures/emma_frost_mental_discipline_5_md"),
			(Texture2D)Resources.Load("Textures/emma_frost_shadowed_thoughts_5_md")};

		gambitTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/gambit_high_stakes_jackpot_md"),
			(Texture2D)Resources.Load("Textures/gambit_hypnotic_charm_3_md"),
			(Texture2D)Resources.Load("Textures/gambit_card_shark_5_md"),
			(Texture2D)Resources.Load("Textures/gambit_stack_deck_5_md")};

		hawkEyeTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/hawkeye_impossible_trick_shot_md"),
			(Texture2D)Resources.Load("Textures/hawkeye_covering_fire_3_md"),
			(Texture2D)Resources.Load("Textures/hawkeye_quick_draw_5_md"),
			(Texture2D)Resources.Load("Textures/hawkeye_team_player_5_md")};

		hulkTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/hulk_hulk_smash_md"),
			(Texture2D)Resources.Load("Textures/hulk_crazed_rampage_3_md"),
			(Texture2D)Resources.Load("Textures/hulk_unstoppable_hulk_5_md"),
			(Texture2D)Resources.Load("Textures/hulk_growing_anger_5_md")};

		ironManTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/ironman_quantum_breakthrough_md"),
			(Texture2D)Resources.Load("Textures/ironman_arc_reactor_3_md"),
			(Texture2D)Resources.Load("Textures/ironman_repulsor_rays_5_md"),
			(Texture2D)Resources.Load("Textures/ironman_endless_invention_5_md")};

		nickFuryTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/nick_fury_pure_fury_md"),
			(Texture2D)Resources.Load("Textures/nick_fury_legendary_commander_3_md"),
			(Texture2D)Resources.Load("Textures/nick_fury_battlefield_promotion_5_md"),
			(Texture2D)Resources.Load("Textures/nick_fury_high_tech_weaponry_5_md")};

		rogueTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/rogue_steal_abilities_md"),
			(Texture2D)Resources.Load("Textures/rogue_copy_powers_3_md"),
			(Texture2D)Resources.Load("Textures/rogue_borrowed_brawn_5_md"),
			(Texture2D)Resources.Load("Textures/rogue_energy_drain_5_md")};

		spidermanTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/spider_man_amazing_spider_man_md"),
			(Texture2D)Resources.Load("Textures/spider_man_web_shooters_3_md"),
			(Texture2D)Resources.Load("Textures/spider_man_great_responsibility_5_md"),
			(Texture2D)Resources.Load("Textures/spider_man_astonishing_strength_5_md")};

		stormTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/storm_tidal_wave_md"),
			(Texture2D)Resources.Load("Textures/storm_spinning_cyclone_3_md"),
			(Texture2D)Resources.Load("Textures/storm_lightning_bolt_5_md"),
			(Texture2D)Resources.Load("Textures/storm_gathering_stormclouds_5_md")};

		thorTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/thor_god_of_thunder_md"),
			(Texture2D)Resources.Load("Textures/thor_call_lightning_3_md"),
			(Texture2D)Resources.Load("Textures/thor_surge_power_5_md"),
			(Texture2D)Resources.Load("Textures/thor_odinson_5_md")};

		wolverineTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/wolverine_beserker_rage_md"),
			(Texture2D)Resources.Load("Textures/wolverine_frenzied_slashing_3_md"),
			(Texture2D)Resources.Load("Textures/wolverine_healing_factor_5_md"),
			(Texture2D)Resources.Load("Textures/wolverine_keen_senses_5_md")};

		mastermindTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/doctor_doom_mastermind_md"),
			(Texture2D)Resources.Load("Textures/loki_mastermind_md"),
			(Texture2D)Resources.Load("Textures/magneto_mastermind_md"),
			(Texture2D)Resources.Load("Textures/red_skull_mastermind_md")};

		drDoomTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/doctor_doom_dark_technology_md"),
			(Texture2D)Resources.Load("Textures/doctor_doom_monarchs_decree_md"),
			(Texture2D)Resources.Load("Textures/doctor_doom_secrets_time_travel_md"),
			(Texture2D)Resources.Load("Textures/doctor_doom_treasures_latveria_md")};

		lokiTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/loki_cruel_ruler_md"),
			(Texture2D)Resources.Load("Textures/loki_maniacal_tyrant_md"),
			(Texture2D)Resources.Load("Textures/loki_vanishing_illusions_md"),
			(Texture2D)Resources.Load("Textures/loki_whispers_lies_md")};

		magnetoTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/magneto_tactic_bitter_captor_md"),
			(Texture2D)Resources.Load("Textures/magneto_tactic_crushing_shockwave_md"),
			(Texture2D)Resources.Load("Textures/magneto_tactic_electromagnetic_bubble_md"),
			(Texture2D)Resources.Load("Textures/magneto_tactic_xaviers_nemesis_md")};

		redSkullTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/red_skull_endless_resources_md"),
			(Texture2D)Resources.Load("Textures/red_skull_hydra_conspiracy_md"),
			(Texture2D)Resources.Load("Textures/red_skull_negablast_grenades_md"),
			(Texture2D)Resources.Load("Textures/red_skull_ruthless_dictator_md")};

		brotherhoodTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/villain_brotherhood_blob_2_md"),
			(Texture2D)Resources.Load("Textures/villain_brotherhood_juggernaut_2_md"),
			(Texture2D)Resources.Load("Textures/villain_brotherhood_mystique_2_md"),
			(Texture2D)Resources.Load("Textures/villain_brotherhood_sabertooth_2_md")};

		enemiesOfAsgardTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/villain_asgard_destroyer_md"),
			(Texture2D)Resources.Load("Textures/villain_asgard_enchantress_2_md"),
			(Texture2D)Resources.Load("Textures/villain_asgard_frost_giant_3_md"),
			(Texture2D)Resources.Load("Textures/villain_asgard_ymir_2_md")};

		hydraTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/villain_hydra_endless_armies_hydra_3_md"),
			(Texture2D)Resources.Load("Textures/villain_hydra_kidnappers_3_md"),
			(Texture2D)Resources.Load("Textures/villain_hydra_supreme_hydra_md"),
			(Texture2D)Resources.Load("Textures/villain_hydra_viper_md")};

		mastersOfEvilTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/villain_masters_baron_zemo_2_md"),
			(Texture2D)Resources.Load("Textures/villain_masters_melter_2_md"),
			(Texture2D)Resources.Load("Textures/villain_masters_ultron_2_md"),
			(Texture2D)Resources.Load("Textures/villain_masters_whirlwind_2_md")};

		radiationTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/villain_radiation_abomination_2"),
			(Texture2D)Resources.Load("Textures/villain_radiation_theleader_2_md"),
			(Texture2D)Resources.Load("Textures/villain_radiation_maestro_2_md"),
			(Texture2D)Resources.Load("Textures/villain_radiation_zzzax_2_md")};

		skrullsTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/villain_skrull_power_skrull_md"),
			(Texture2D)Resources.Load("Textures/villain_skrull_queen_veranke_md"),
			(Texture2D)Resources.Load("Textures/villain_skrull_shapeshifters_3_md"),
			(Texture2D)Resources.Load("Textures/villain_skrull_super_skrull_3_md")};

		spiderFoesTextures = new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/villain_spider_foes_doctor_octopus_2_md"),
			(Texture2D)Resources.Load("Textures/villain_spider_foes_green_goblin_2_md"),
			(Texture2D)Resources.Load("Textures/villain_spider_foes_the_lizard_2_md"),
			(Texture2D)Resources.Load("Textures/villain_spider_foes_venom_2_md")};

		henchmenTextures =new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/henchmen_doombot_legion_10_md"),
			(Texture2D)Resources.Load("Textures/henchmen_hand_ninjas_10_md"),
			(Texture2D)Resources.Load("Textures/henchmen_savage_land_mutants_10_md"),
			(Texture2D)Resources.Load("Textures/henchman_sentinel_10_med")};

		schemeTextures =new List<Texture2D>(){
			(Texture2D)Resources.Load("Textures/scheme_legacy_virus_md"),
			(Texture2D)Resources.Load("Textures/scheme_midtown_bank_robbery_md"),
			(Texture2D)Resources.Load("Textures/scheme_negative_zone_prison_breakout_md"),
			(Texture2D)Resources.Load("Textures/scheme_portals_dark_dimension_md"),
			(Texture2D)Resources.Load("Textures/scheme_replace_leaders_killbots_md"),
			(Texture2D)Resources.Load("Textures/scheme_secret_invasion_shapeshifters_md"),
			(Texture2D)Resources.Load("Textures/scheme_super_hero_civil_war_md"),
			(Texture2D)Resources.Load("Textures/scheme_unleash_cosmic_cube_md")};
	}

	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreatePlayers()
	{
		for(int i = 0; i < numberOfPlayer; i++)
		{
			playerOrder.Add(new Player(playerNames[i]));
		}
	}
}

package com.example.tdd;

import static org.hamcrest.Matchers.*;
import static org.mockito.Mockito.*;
import static org.springframework.test.web.servlet.request.MockMvcRequestBuilders.*;
import static org.springframework.test.web.servlet.result.MockMvcResultMatchers.*;

import java.util.Arrays;
import java.util.List;

import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.autoconfigure.web.servlet.AutoConfigureMockMvc;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.boot.test.mock.mockito.MockBean;
import org.springframework.test.web.servlet.MockMvc;

@SpringBootTest
@AutoConfigureMockMvc
public class BlogTest {

	@MockBean
	private BlogService blogService;
	
	@Autowired
	private MockMvc mockMvc;
	
	private static final int MOCK_FIRST_ID = 1;
	private static final String MOCK_FIRST_TITLE = "TDD One";
	private static final String MOCK_FIRST_CONTENT = "This is TDD One's content";
	
	private static final int MOCK_SECOND_ID = 2;
	private static final String MOCK_SECOND_TITLE = "TDD and BDD";
	private static final String MOCK_SECOND_CONTENT = "This is TDD and BDD's content";
		
	@Test
	public void testReturnsListOfPosts() throws Exception {
		//mock
		List<Post> mockPosts = Arrays.asList(
				new Post(MOCK_FIRST_ID, MOCK_FIRST_TITLE, MOCK_FIRST_CONTENT),
				new Post(MOCK_SECOND_ID, MOCK_SECOND_TITLE, MOCK_SECOND_CONTENT)
		);
		doReturn(mockPosts).when(blogService).findAll();
				
		//perform and test
		mockMvc.perform(get("/posts"))
			.andExpect(status().isOk())
			.andExpect(jsonPath("$", hasSize(mockPosts.size())))
			
			.andExpect(jsonPath("$[0].id", is(MOCK_FIRST_ID)))
			.andExpect(jsonPath("$[0].title", is(MOCK_FIRST_TITLE)))
			.andExpect(jsonPath("$[0].content", is(MOCK_FIRST_CONTENT)))
			
			.andExpect(jsonPath("$[1].id", is(MOCK_SECOND_ID)))
			.andExpect(jsonPath("$[1].title", is(MOCK_SECOND_TITLE)))
			.andExpect(jsonPath("$[1].content", is(MOCK_SECOND_CONTENT)));
	}
	
}
